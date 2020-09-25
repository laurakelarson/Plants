using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plants.Controllers;

namespace UnitTestPlants
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void HomeControllerIndexShouldPass()
        {
            HomeController hc = new HomeController();
            var res = hc.Index();

            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void HomeControllerAboutUsShouldPass()
        {
            HomeController hc = new HomeController();
            var res = hc.AboutUs();

            Assert.IsNotNull(res);
        }

    }
}
