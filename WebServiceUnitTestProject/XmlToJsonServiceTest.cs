using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.WebServiceController;

namespace WebServiceUnitTestProject
{
    [TestClass]
    public class XmlToJsonServiceTest
    {
        private XmlToJsonServiceController _controller = new XmlToJsonServiceController();

        #region For the Method IsValidXml
        //*********************************************************
        
        [TestMethod()]
        public void TestValidXml()
        {
            string xml = "<result>true</result>";
            Assert.IsTrue(_controller.IsValidXml(xml));
        }

        [TestMethod()]
        public void TestIsNotValidXml()
        {
            string json = "{ \"result\": \"true\" }";
            Assert.IsFalse(_controller.IsValidXml(json));
        }
        [TestMethod()]
        public void TestIsNotValidXml2()
        {
            string json = "<foo>hello</bar>";
            Assert.IsFalse(_controller.IsValidXml(json));
        }
        //*********************************************************
        #endregion For the Method IsValidXml

        #region For the Method XmlToJson
        //*********************************************************

        [TestMethod()]
        public void TestXmlToJsonWithValidXmlSimple()
        {
            string xml = "<foo>bar</foo>";
            string jsonResult = _controller.XmlToJson(xml);
            string expected = "{\"foo\":\"bar\"}";
            Assert.AreEqual(expected,jsonResult);
        }

        [TestMethod()]
        public void TestXmlToJsonWithNotValidXml()
        {
            string xml = "<foo>hello</bar>";
            string jsonResult = _controller.XmlToJson(xml);
            string expected = "Bad Xml format";
            Assert.AreEqual(expected, jsonResult);
        }
        
        //*********************************************************
        #endregion For the Method XmlToJson
    }
}
