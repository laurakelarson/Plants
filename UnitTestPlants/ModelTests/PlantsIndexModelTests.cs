using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plants.Models;


namespace UnitTestPlants
{
    [TestClass]
    public class PlantsIndexModelTests
    {
        [TestMethod]
        public void TestDefaultConstructorShouldPass()
        {
            PlantsIndexModel plantsIndexModel = new PlantsIndexModel();
            Assert.IsNotNull(plantsIndexModel);
        }
    }
}
