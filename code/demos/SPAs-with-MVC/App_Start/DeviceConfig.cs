using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace SPAs_with_MVC
{
    public class DeviceConfig
    {
        public static void ConfigureDisplayModes()
        {
            // ANDROID
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("android")
            {
                ContextCondition = context => context.GetOverriddenUserAgent().ToLower().Contains("android")
            });

            // IOS
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("ios")
            {
                ContextCondition = context => 
                    context.GetOverriddenUserAgent().ToLower().Contains("iphone") ||
                    context.GetOverriddenUserAgent().ToLower().Contains("ipad") ||
                    context.GetOverriddenUserAgent().ToLower().Contains("ipod")
            });
        }
    }

}