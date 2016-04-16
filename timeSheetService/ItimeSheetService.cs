using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using timeSheetService.dataContracts;

namespace timeSheetService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ItimeSheetService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/getDate", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        contractGetDate getDate();

    }

}