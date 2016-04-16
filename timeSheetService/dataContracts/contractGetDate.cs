using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace timeSheetService.dataContracts
{
    [DataContract]
    public class contractGetDate
    {
        string dateValue = DateTime.Now.ToString();
        [DataMember]
        public string DateValue
        {
            get { return dateValue; }
            set { dateValue = value; }

        }
    }
}