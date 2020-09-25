using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plants.Models;

namespace UnitTestPlants
{
    [TestClass]
    public class PlantModelTests
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            PlantModel plantTest = new PlantModel();
            Assert.IsTrue(true);
        }

    }
}
