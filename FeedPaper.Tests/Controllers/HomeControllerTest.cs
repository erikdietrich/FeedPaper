using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FeedPaper;
using FeedPaper.Controllers;

namespace FeedPaper.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result.ViewBag.Message);
        }

        [TestClass]
        public class About
        {
            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_Non_Null_ViewResult()
            {
                var controller = new HomeController();

                Assert.IsNotNull(controller.About() as ViewResult);
            }

            [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_ViewResult_With_Description_Matching_Class_Description()
            {
                var controller = new HomeController();
                var result = controller.About() as ViewResult;

                Assert.AreEqual(HomeController.AboutFeedpaperDescription, result.ViewBag.Description);
            }
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
