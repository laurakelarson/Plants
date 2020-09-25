using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plants.Models;

namespace UnitTestPlants
{
    [TestClass]
    public class PlantModelTests
    {
        [TestMethod]
        public void TestDefaultConstructorShouldPass()
        {
            PlantModel plantTest = new PlantModel();
            Assert.IsNotNull(plantTest);
        }

        [TestMethod]
        public void TestCopyConstructorShouldPass()
        {
            PlantModel plantTest = new PlantModel
            {
                ScientificName = "BOGUS",
                CommonName = "PLANT",
                Family = "FAMILY",
                Category = Plants.Models.Enums.CategoryEnum.Monocot,
                Duration = Plants.Models.Enums.DurationEnum.Perennial,
                ImageURI = "FAKE.jpg"
            };
            // Use copy constructor
            PlantModel plantCopy = new PlantModel(plantTest);

            Assert.AreEqual(plantCopy.CommonName, "PLANT");
            Assert.AreEqual(plantCopy.ScientificName, "BOGUS");
            Assert.AreEqual(plantCopy.Family, "FAMILY");
            Assert.AreEqual(plantCopy.Category, Plants.Models.Enums.CategoryEnum.Monocot);
            Assert.AreEqual(plantCopy.Duration, Plants.Models.Enums.DurationEnum.Perennial);
            Assert.AreEqual(plantCopy.ImageURI, "FAKE.jpg");
        }

        [TestMethod]
        public void TestUpdateShouldReturnFalse()
        {
            PlantModel plantTest = new PlantModel
            {
                ScientificName = "BOGUS",
                CommonName = "PLANT",
                Family = "FAMILY",
                Category = Plants.Models.Enums.CategoryEnum.Monocot,
                Duration = Plants.Models.Enums.DurationEnum.Perennial,
                ImageURI = "FAKE.jpg"
            };

            var res = plantTest.Update(null);
            Assert.IsFalse(res);
        }
    }
}
