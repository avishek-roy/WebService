using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for MathWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class MathWebService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<long> GetOdds(List<long> numberList)
        {
            return numberList.Where(obj => obj % 2 == 1).Select(obj => obj).ToList();
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<long> GetEvens(List<long> numberList)
        {
            return numberList.Where(obj => obj % 2 == 0).Select(obj => obj).ToList();
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public long GetSum(List<long> numberList)
        {
            return numberList.Select(obj => obj).Sum();
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public long GetMode(long number, long mobeBy)
        {
            return number %= mobeBy;
        }
    }
}
