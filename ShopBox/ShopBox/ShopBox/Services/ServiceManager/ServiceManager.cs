using Newtonsoft.Json;
using Prism.Services;
using ShopBox.ErrorLogging;
using ShopBox.Helpers;
using ShopBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Services
{
    public  class ServiceManager : IServiceManager
    {
        #region fields
        ServiceResponse svcResponse= new ServiceResponse();
#endregion

        #region constructor
        public ServiceManager()
        {
            svcResponse.ErrorObject = new ErrorBase();
            svcResponse.ErrorObject.error = new Error();
        }


        #endregion

        #region method


        /// <summary>
        /// GetData is ageneric method to call restfull service and getting the data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public async Task<ServiceResponse> GetData<T>(string methodName)
        {
            string response = string.Empty;
          
                try
                {
                    string serviceUrl = Helpers.AppConstants.GetSettingsItem("BaseURL");

                    if (string.IsNullOrEmpty(serviceUrl))
                    {   
                        svcResponse.ErrorObject.error.message = AppConstants.CantReadSettingfile;
                        svcResponse.Success = false;
                        return svcResponse;
                    }
                    Uri geturi = new Uri(serviceUrl + methodName, UriKind.RelativeOrAbsolute);
                using (var client = new HttpClient())
                {
                    System.Net.Http.HttpResponseMessage getResponse = await client.GetAsync(geturi);
                    response = await getResponse.Content.ReadAsStringAsync();
                    if (getResponse.IsSuccessStatusCode)
                    {
                        svcResponse.ResponseObject = JsonConvert.DeserializeObject<T>(response);
                        svcResponse.Success = true;
                        return svcResponse;
                    }
                    else
                    {
                        try
                        {
                            svcResponse.ErrorObject = JsonConvert.DeserializeObject<ErrorBase>(response);

                        }
                        catch (Exception ex)
                        {
                           
                            svcResponse.ErrorObject.error.message = ex.Message;
                            svcResponse.Success = false;
                            svcResponse.ErrorObject.error.name = AppConstants.UnhandledException;
                           
                        }

                        svcResponse.ResponseObject = null;
                        svcResponse.Success = false;
                        return svcResponse;
                    }
                }
                }
                catch (HttpRequestException ex)
                {
                  
                    svcResponse.ResponseObject = null;
                    svcResponse.ErrorObject.error.name = AppConstants.HttpRequestException;
                    svcResponse.ErrorObject.error.message = ex.Message;
                    svcResponse.Success = false;
                 
            }
                catch (JsonSerializationException ex)
                {
                    if (!string.IsNullOrEmpty(response))
                    {
                  
                    svcResponse.ErrorObject.error.name = AppConstants.SerilizationExceptoin;
                    svcResponse.ErrorObject.error.message = ex.Message;
                    svcResponse.Success = false;
                    }
                    else
                    {
              
                        svcResponse.ErrorObject.error.name = AppConstants.SerilizationExceptoin;
                        svcResponse.ErrorObject.error.message = ex.Message;
                        svcResponse.Success = false;
                    }
              

            }
                catch (Exception ex)
                {
                
                    svcResponse.ErrorObject.error.message = ex.Message;
                    svcResponse.ErrorObject.error.name = AppConstants.UnhandledException;
                    svcResponse.Success = false;
               
            }
           

            return svcResponse;

        }

        /// <summary>
        /// PostData is ageneric method to authenticate the users 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methodName"></param>
        /// <param name="postedObject"></param>
        /// <returns></returns>
        public async Task<ServiceResponse> PostData<T>(string methodName, object postedObject)
        {
            string response = string.Empty;
           
                try
                {
                    string serviceUrl = Helpers.AppConstants.GetSettingsItem("BaseURL");

                    Uri requestUri = new Uri(serviceUrl + methodName, UriKind.RelativeOrAbsolute);
                    string json = "";

                    json = Newtonsoft.Json.JsonConvert.SerializeObject(postedObject);
                    var objClint = new System.Net.Http.HttpClient();

                    System.Net.Http.HttpResponseMessage respon = await objClint.PostAsync(requestUri, new StringContent(json, System.Text.Encoding.UTF8, "application/json"));
                    response = await respon.Content.ReadAsStringAsync();

                    if (respon.IsSuccessStatusCode)
                    {
                        svcResponse.ResponseObject = JsonConvert.DeserializeObject<T>(response);
                        svcResponse.Success = true;
                        return svcResponse;
                    }
                    else
                    {
                        try
                        {
                            svcResponse.ErrorObject = JsonConvert.DeserializeObject<ErrorBase>(response);   
                        }
                        catch (Exception ex)
                        {
                         
                            svcResponse.ErrorObject.error.message = ex.Message;
                            svcResponse.Success = false;
                            svcResponse.ErrorObject.error.name = AppConstants.UnhandledException; ;
                        }


                        svcResponse.ResponseObject = null;
                        svcResponse.Success = false;
                        return svcResponse;

                    }

                }
                catch (HttpRequestException ex)
                {
             
                    svcResponse.ResponseObject = null;
                    
                    svcResponse.ErrorObject.error.name = AppConstants.HttpRequestException;
                    svcResponse.ErrorObject.error.message = ex.Message;
                    svcResponse.Success = false;
                   

                }
                catch (JsonSerializationException ex)
                {
                    if (!string.IsNullOrEmpty(response))
                    {

                        svcResponse.ErrorObject.error.name = AppConstants.SerilizationExceptoin;
                        svcResponse.ErrorObject.error.message = ex.Message;
                        svcResponse.Success = false;
                    }
                    else
                    {
                       
                        svcResponse.ErrorObject.error.name = AppConstants.SerilizationExceptoin;
                        svcResponse.ErrorObject.error.message = ex.Message;
                        svcResponse.Success = false;
                    }
                 
                }
                catch (Exception ex)
                {
                 
                    svcResponse.ErrorObject.error.message = ex.Message;
                    svcResponse.ErrorObject.error.name = AppConstants.UnhandledException;
                    svcResponse.Success = false;
                }
            
            return svcResponse;
        }

        #endregion
    }
    
}
