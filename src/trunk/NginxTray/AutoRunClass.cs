using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace NginxTray
{
    
    // This is a hepler-class for add/remove the program to the Auto Run (starting with Windows)
    public class AutoRun
    {
        public AutoRun()
        {
            //this.appName = System.AppDomain.CurrentDomain.FriendlyName;
            this.appName = "NginxTray";
        }


        public void addAutoRun()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (! this.IsStartupItem())
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue(this.appName, Application.ExecutablePath.ToString());
        }

        public void removeAutoRun()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (this.IsStartupItem())
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue(this.appName, false);
        }


        public bool IsStartupItem()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue(this.appName) == null)
                // The value doesn't exist, the application is not set to run at startup
                return false;
            else
                // The value exists, the application is set to run at startup
                return true;
        }

        public string appName;
    }
}
