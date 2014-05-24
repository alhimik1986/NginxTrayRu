using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace NginxTray
{
    public class ProcessManagement
    {

        //Start a new process
        public bool StartProcess(string process, string arguments = "")
        {

            Process Proc = new Process();

            Proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(process)); //Process Directory
            Proc.StartInfo.FileName = Path.GetFileNameWithoutExtension(process); //Process FileName
            Proc.StartInfo.Arguments = arguments; //Process optional arguments
            Proc.StartInfo.CreateNoWindow = true; //Set no display windows
            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Set no display any window
            
            try
            {
                Proc.Start();
            }
            catch
            {
                return false;
            }

            return true;
        }

        //Stop a process
        public void StopProcess(string process)
        {
            process = Path.GetFileNameWithoutExtension(process);

            Process[] processgroup = Process.GetProcessesByName(process); // Select processes with that name

            foreach (Process Proc in processgroup)
            {
                Proc.Kill(); // Stop each process with that name
            }

        }
    }
}
