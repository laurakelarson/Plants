using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plants.Controllers;

namespace UnitTestPlants
{
    [TestClass]
    public class PlantsIndexControllerTests
    {
        [TestMethod]
        public void HomeControllerIndexShouldPass()
        {
            PlantsIndexController hc = new PlantsIndexController();
            var res = hc.PlantsIndex();

            Assert.IsNotNull(res);
        }
    }
}
