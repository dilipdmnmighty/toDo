using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace timeSheetDAL.DataAccess
{
    internal class dataAccess
    {
        internal SqlConnection _con = new SqlConnection();
        internal SqlCommand cmd = new SqlCommand();

        public SqlConnection Getconnection()
        {
            try
            {
                if (_con.State == ConnectionState.Closed)
                {
                    _con.ConnectionString = ConfigurationManager.ConnectionStrings["connDataAccess"].ToString();
                    _con.Open();
                }
            }
            catch (Exception ex)
            {
                String msgInnerExAndStackTrace = String.Format("{0}; Inner Ex: {1}; Stack Trace: {2}", ex.Message, ex.InnerException, ex.StackTrace);
                return null;
            }
            return _con;
        }

        public DataTable timeSheetDALTbl(string str, SqlCommand cmd)
        {
            try
            {
                SqlCommand newcmd = new SqlCommand();
                newcmd = cmd;
                newcmd.CommandType = CommandType.StoredProcedure;
                newcmd.CommandText = str;
                newcmd.Connection = Getconnection();
                SqlDataAdapter data_adp = new SqlDataAdapter(cmd);
                DataTable dttable = new DataTable();
                data_adp.Fill(dttable);
                return dttable;
            }
            catch (Exception ex)
            {
                String msgInnerExAndStackTrace = String.Format("{0}; Inner Ex: {1}; Stack Trace: {2}", ex.Message, ex.InnerException, ex.StackTrace);
                return null;
            }
            finally
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                }
            }
        }

        public DataSet timeSheetDALDs(string str, SqlCommand cmd)
        {
            try
            {
                SqlCommand newcmd = new SqlCommand();
                newcmd = cmd;
                newcmd.CommandType = CommandType.StoredProcedure;
                newcmd.CommandText = str;
                newcmd.Connection = Getconnection();
                SqlDataAdapter data_adp = new SqlDataAdapter(cmd);
                DataSet dstable = new DataSet();
                data_adp.Fill(dstable);
                _con.Close();
                return dstable;
            }
            catch (Exception ex)
            {
                String msgInnerExAndStackTrace = String.Format("{0}; Inner Ex: {1}; Stack Trace: {2}", ex.Message, ex.InnerException, ex.StackTrace);
                return null;
            }
            finally
            {
                if (_con.State == ConnectionState.Open)
                {
                    _con.Close();
                }
            }
        }
    }
}