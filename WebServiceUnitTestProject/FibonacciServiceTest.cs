using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.WebServiceController;

namespace WebServiceUnitTestProject
{
    [TestClass]
    public class FibonacciServiceTest
    {
        FibonacciServiceController _controller = new FibonacciServiceController();
        [TestMethod]
        public void TestNIsZero()
        {
            int returnValue = _controller.Fibonacci(0);
            Assert.AreEqual(-1,returnValue);
        }
        [TestMethod]
        public void TestNIsLessThanZero()
        {
            int returnValue = _controller.Fibonacci(-101);
            Assert.AreEqual(-1, returnValue);
        }
        [TestMethod]
        public void TestNIsMoreThanOneHundred()
        {
            int returnValue = _controller.Fibonacci(1000);
            Assert.AreEqual(-1, returnValue);
        }
        [TestMethod]
        public void TestNIsOne()
        {
            int returnValue = _controller.Fibonacci(1);
            Assert.AreEqual(1, returnValue);
        }
        [TestMethod]
        public void TestNIsTwo()
        {
            int returnValue = _controller.Fibonacci(2);
            Assert.AreEqual(1, returnValue);
        }

        [TestMethod]
        public void TestNIsSix()
        {
            int returnValue = _controller.Fibonacci(6);
            
            Assert.AreEqual(8, returnValue);
        }
        //[TestMethod]
        public void TestNIs50()
        {
            int returnValue = _controller.Fibonacci(50);
            Assert.AreEqual(1, returnValue);
        }
    }
}
