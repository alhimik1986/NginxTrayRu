using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;
using System.Reflection;

namespace NginxTray
{
    
    // This is a hepler-class for add/remove the program to the Auto Run (starting with Windows)
    public class AutoRun
    {
        public string appLink;
        public string autoRunPath;
        public string appName;
        public string appPath;
        public string workingDirectory;

        public AutoRun()
        {
            // including IWshRuntimeLibrary.dll in the .exe-project
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            

            this.appLink = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            this.workingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            this.autoRunPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            this.appName = Path.GetFileNameWithoutExtension(this.appLink);
            this.appPath = Path.GetDirectoryName(appLink);

            IWshRuntimeLibrary.FileSystemObject a = new IWshRuntimeLibrary.FileSystemObject();
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



        // Add the application's shortcut to AutoRun folder
        // http://www.sorrowman.org/c-sharp-programmer/url-link-to-desktop.html
        public void addAppShortcutToAutoRunFolder()
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(this.autoRunPath + @"\" + this.appName + ".lnk");
            shortcut.Description = "";
            shortcut.Hotkey = "";
            shortcut.TargetPath = this.appLink;
            shortcut.WorkingDirectory = this.workingDirectory;
            shortcut.Save();
        }



        // Remove the application's shortcut in AutoRun folder
        public void removeAppShortcutToAutoRunFolder()
        {
            System.IO.File.Delete(this.autoRunPath + @"\" + this.appName + ".lnk");
        }

        // Add/Remove the application's shortcut in AutoRun folder
        public void appShortcutToAutoRunFolder(bool value)
        {
            if (value) {
                this.addAppShortcutToAutoRunFolder();
            } else {
                this.removeAppShortcutToAutoRunFolder();
            }
        }

        // is set the auto run
        public bool isAutoRun()
        {
            return System.IO.File.Exists(this.autoRunPath + @"\" + this.appName + ".lnk");
        }

        // for init included IWshRuntimeLibrary.dll
        private void foo()
        {
            IWshRuntimeLibrary.FileSystemObject a = new IWshRuntimeLibrary.FileSystemObject();
        }

    }
}
