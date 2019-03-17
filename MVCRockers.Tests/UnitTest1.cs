using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCRockers.Controllers;

namespace MVCRockers.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FooActionReturnsAboutView()
        {
            // Arrange
            HomeController controller = new HomeController();


            // Act
            var results = controller.Foo() as ViewResult;


            // Assert
            Assert.AreEqual("About", results.ViewName);

        }

        [TestMethod]
        public void VerifyIndexShowsNewSplashScreen()
        {
            HomeController controller = new HomeController();

            var results = controller.Index() as ViewResult;

            Assert.AreEqual("Splash", results.ViewName);

        }

    }
}
