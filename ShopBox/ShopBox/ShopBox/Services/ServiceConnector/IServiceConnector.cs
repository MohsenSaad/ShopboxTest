using ShopBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Services
{
   public interface IServiceConnector
    {
        Task<ServiceResponse> Login(string username, string password);
        Task<ServiceResponse> GetAllStors(string accessToken);
        Task<ServiceResponse> GetAllBranches(string accessToken, string clientId);
        Task<ServiceResponse> GetAllProducts(string accessToken, string clientId);

      
    }
}
