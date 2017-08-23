using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Services
{
  public interface IServiceManager
    {
        Task<ServiceResponse> PostData<T>(string methodName, Object postedObject);
        Task<ServiceResponse> GetData<T>(string methodName);
    }
}
