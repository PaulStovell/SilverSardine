using System.Web.Mvc;
using NUnit.Framework;
using SilverSardine.Web.Controllers;

namespace SilverSardine.Tests.Web.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController controller;

        [SetUp]
        public void SetUp()
        {
            controller = new HomeController();
        }

        [Test]
        public void Index_ShouldSayHello()
        {
            var result = controller.Index() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(controller.ViewBag.Message, Is.EqualTo("Hello world!"));
        }
    }
}