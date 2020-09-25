using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plants.Models;
using System.Collections.Generic;

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

        [TestMethod]
        public void GetPlantsListShouldPass()
        {
            PlantsIndexModel plantsIndexModel = new PlantsIndexModel();

            List<PlantModel> list = plantsIndexModel.PlantsList;
            Assert.AreEqual(list[0].CommonName, "Monstera");
        }
    }
}
