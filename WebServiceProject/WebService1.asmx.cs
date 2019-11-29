using Server.WebServiceController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Server.WebServiceProject
{
    /// <summary>
    /// WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        /// <summary>
        /// web mrthod of Fibonacci
        /// </summary>
        /// <param name="n">input value</param>
        /// <returns>result value</returns>
        [WebMethod]
        public int Fibonacci(int n)
        {
            FibonacciServiceController controller = new FibonacciServiceController();
            return controller.Fibonacci(n);
        }
        /// <summary>
        /// WebMethods of XmlToJson
        /// </summary>
        /// <param name="xml">xml</param>
        /// <returns>json</returns>
        [WebMethod]
        public string XmlToJson(string xml)
        {
            XmlToJsonServiceController controller = new XmlToJsonServiceController();
            return controller.XmlToJson(xml);
        }
    }
}
