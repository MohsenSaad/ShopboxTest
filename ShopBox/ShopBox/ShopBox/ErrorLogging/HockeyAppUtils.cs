using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.ErrorLogging
{
   public class HockeyAppUtils
    {
        public static void TrackException(string methodName, Exception ex)
        {
            var dic = new Dictionary<string, string>()
                {
                    { "Time" , DateTime.UtcNow.ToString()},
                    { "At" , methodName},
                    { "ExceptionType", ex.GetType().ToString() },
                    { "ExMessage", ex.Message },
                    { "StackTrace", ex.StackTrace != null ? ex.StackTrace : "No Stack Trace Avaliable" }
                };
            HockeyApp.MetricsManager.TrackEvent("Handled Exception", dic, new Dictionary<string, double>());
        }
    }
}
