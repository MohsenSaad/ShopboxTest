using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.Helpers
{

    /// <summary>
    /// Class to hold app constants and keys
    /// </summary>
   public class AppConstants
    {

         #region fields
        private static Dictionary<string, string> settingsCollection = null;
        public static string AuthenticateLogin = "api/v3/authenticate/credentials";
        public static string Getallstores = "api/clients/myclients?accessToken={0}";
        public static string GetallBranches = "api/v3/branches?accessToken={0}&client={1}";
        public static string Getallproducts = "api/products?accessToken={0}&client={1}";
        public static string UserNameKey = "username";
        public static string PasswordKey = "password";
        public static string UnhandledException = "UnhandledException";
        public static string SerilizationExceptoin = "SerilizationExceptoin";
        public static string CantReadSettingfile = "CantReadSettingFile";
        public static string NoInternetConnection = "Please check your internet connection";
        public static string HttpRequestException = "HttpRequestException";
        public static string AccessToken = "accesstoken";
        public static string ClientIdKey = "clientid";
        public static string TokenValue;
        #endregion

         #region methods
        /// <summary>
        /// method to get setting item by its key from Dictionary collection
        /// </summary>
        /// <param name="settingkey"></param>
        /// <returns></returns>
        public static string GetSettingsItem(string settingkey)
        {
            if (settingsCollection == null)
            {
                settingsCollection = new Dictionary<string, string>();
                settingsCollection.Add("BaseURL", "https://api-dev.shopbox.com/");
            }

            if (settingsCollection.Keys.Contains(settingkey))
            {
                return settingsCollection[settingkey];
            }
            return string.Empty;
        }
        #endregion
    }
}
