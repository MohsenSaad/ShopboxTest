using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopBox.Services;
using System.Threading.Tasks;

namespace Shopbox.UnitTest
{
    [TestClass]
    public class ServiceConnectotUnitTest
    {
        [TestMethod]
        [TestCategory("Authentiation")]
        public async Task IsUserAuthenticated()
        {
             ServiceConnector connector = new ServiceConnector();
             ServiceResponse response=  await connector.Login("test@shopbox.com", "123456");
             Assert.IsTrue(response.Success,"Authentication error");
            
        }

        [TestMethod]
        [TestCategory("Getting Stors")]
        public async Task IsStoresReturned()
        {
            ServiceConnector connector = new ServiceConnector();
            ServiceResponse response = await connector.GetAllStors("38c327e06f746809762fff30fc7a8626");
            Assert.IsTrue(response.Success, "Eror in getting data");

        }

        [TestMethod]
        [TestCategory("Getting Branches")]
        public async Task IsBranchesReturned()
        {
            ServiceConnector connector = new ServiceConnector();
            ServiceResponse response = await connector.GetAllBranches("38c327e06f746809762fff30fc7a8626", "2664");
            Assert.IsTrue(response.Success, "Eror in getting Branches");

        }

        [TestMethod]
        [TestCategory("Getting Prducts")]
        public async Task IsProductsReturned()
        {
            ServiceConnector connector = new ServiceConnector();
            ServiceResponse response = await connector.GetAllProducts("38c327e06f746809762fff30fc7a8626", "2664");
            Assert.IsTrue(response.Success, "Eror in getting Prducts");

        }

    }
}
