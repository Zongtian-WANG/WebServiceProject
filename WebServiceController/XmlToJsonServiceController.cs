using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Server.WebServiceController
{
    /// <summary>
    /// Controller for the service XmlToJson
    /// </summary>
    public class XmlToJsonServiceController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(XmlToJsonServiceController));
        /// <summary>
        /// Service of XmlToJson
        /// </summary>
        /// <param name="xml">Xml</param>
        /// <returns>Json</returns>
        public string XmlToJson(string xml)
        {
            log.Info("call XmlToJson");
            bool isGoodFormat = IsValidXml(xml);
            if(isGoodFormat)
            {
                return GetJson(xml);
            }
            return "Bad Xml format";
        }

        public bool IsValidXml(string xmlString)
        {
            Regex tagsWithData = new Regex("<\\w+>[^<]+</\\w+>");

            if (string.IsNullOrEmpty(xmlString) || tagsWithData.IsMatch(xmlString) == false)
            {
                return false;
            }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlString);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string GetJson(string xml)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            XDocument doc = XDocument.Parse(xmlDocument.OuterXml);
            // removce the nodes without value
            doc.Descendants().Where(x => ((string)x == "null" || (string)x == "")).Remove();

            // remove the attributes for the node
            var nodes = doc.Descendants().Where(x => x.HasAttributes);
            foreach (var item in nodes)
            {
                item.RemoveAttributes();
            }
            //var result = JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
            var result = JsonConvert.SerializeObject(doc);
            return result;
        }
    }
}
