using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plants.Models;

namespace UnitTestPlants
{
    [TestClass]
    public class ErrorViewModelTests
    {
        [TestMethod]
        public void SetRequestIdShouldPass()
        {
            ErrorViewModel evm = new ErrorViewModel();
            evm.RequestId = "BOGUS";

            Assert.AreEqual(evm.RequestId, "BOGUS");
        }

        [TestMethod]
        public void GetRequestIdShouldPass()
        {
            ErrorViewModel evm = new ErrorViewModel
            {
                RequestId = "BOGUS"
            };
            var res = evm.RequestId;

            Assert.AreEqual(res, "BOGUS");
        }

        [TestMethod]
        public void ShowRequestIdShouldPass()
        {
            ErrorViewModel evm = new ErrorViewModel
            {
                RequestId = "BOGUS"
            };
            var res = evm.ShowRequestId;

            Assert.IsTrue(res);
        }
    }
}
