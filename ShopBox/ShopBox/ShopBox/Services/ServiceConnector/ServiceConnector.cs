using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopBox.Models;
using System.Net.Http;
using Newtonsoft.Json;
using ShopBox.Helpers;
using ShopBox.Models.Clients;
using ShopBox.Models.Products;
using ShopBox.Models.Branches;

namespace ShopBox.Services
{
    public class ServiceConnector : IServiceConnector
    {
        #region fileds
        ServiceManager svcmanager = new ServiceManager();


        #endregion

        #region methods

        /// <summary>
        /// Get all branches by accessToken and ClientId
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<ServiceResponse> GetAllBranches(string accessToken, string clientId)
        {
            var response = await svcmanager.GetData<BranchRootObject>(String.Format(AppConstants.GetallBranches, accessToken, clientId));
            return response;
        }

        /// <summary>
        ///  Get all products by accessToken and ClientId
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public async Task<ServiceResponse> GetAllProducts(string accessToken, string clientId)
        {
            var response = await svcmanager.GetData<ProductModel>(String.Format(AppConstants.Getallproducts, accessToken, clientId));
            return response;
        }

        /// <summary>
        /// get all stors by accessToken
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<ServiceResponse> GetAllStors(string accessToken)
        {
            var response = await svcmanager.GetData<ClientModel>(String.Format(AppConstants.Getallstores, accessToken));
            return response;
        }

        /// <summary>
        /// login method for user authentication
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<ServiceResponse> Login(string username, string password)
        {
            Dictionary<string, string> credentials = new Dictionary<string, string>();
            credentials.Add(AppConstants.UserNameKey, username);
            credentials.Add(AppConstants.PasswordKey, password);
            var response=await svcmanager.PostData<UserAccount>(AppConstants.AuthenticateLogin, credentials);
            return response;
        }

        #endregion

    }
}
