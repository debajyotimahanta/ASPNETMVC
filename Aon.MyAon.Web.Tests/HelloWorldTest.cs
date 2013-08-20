using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aon.MyAon.Web.Controllers;
using System.Web.Mvc;

namespace Aon.MyAon.Web.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.AreEqual("Hello World", result.ViewBag.Message);

        }
    }
}
