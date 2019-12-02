using log4net;
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
        private static readonly ILog log = LogManager.GetLogger(typeof(FibonacciServiceController));
        /// <summary>
        /// web mrthod of Fibonacci
        /// </summary>
        /// <param name="n">input value</param>
        /// <returns>result value</returns>
        [WebMethod]
        public int Fibonacci(int n)
        {
            log.Info("Begin call Fibonacci with value n => " + n);
            FibonacciServiceController controller = new FibonacciServiceController();
            int resultValue = controller.Fibonacci(n);
            log.Info("End call Fibonacci with result => " + resultValue);
            return resultValue;
        }
        /// <summary>
        /// WebMethods of XmlToJson
        /// </summary>
        /// <param name="xml">xml</param>
        /// <returns>json</returns>
        [WebMethod]
        public string XmlToJson(string xml)
        {
            log.Info("Begin call XmlToJson with value xml => " + xml);
            XmlToJsonServiceController controller = new XmlToJsonServiceController();
            string resultValue = controller.XmlToJson(xml);
            log.Info("Begin call XmlToJson with json result => " + resultValue);
            return resultValue;
        }
    }
}
