using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;
using System.Configuration;
using System.Management;

namespace NginxTray
{
    public class ProcessManagement
    {
        // the number of string (starts from 0) in textBoxFiles to define the failed process
        public int ProcessIndex;
        // ID list of running processes.
        public int[] pids;


        public bool start()
        {
            string[] files = Properties.Settings.Default.Files.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string[] args = Properties.Settings.Default.Arguments.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string[] envs = Properties.Settings.Default.EnvironmentVariables.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            this.pids = new int[files.Length];

            string file; string arg;

            for (int i = 0; i < files.Length; i++)
            {
                file = files.Length >= i + 1 ? files[i] : "";
                arg = args.Length >= i + 1 ? args[i] : "";
                if (file.Length == 0) continue;
                try
                {
                    this.pids[i] = this.StartProcess(file, arg, envs);

                    if (this.pids[i] == 0)
                    {
                        this.ProcessIndex = i + 1;
                        return false;
                    }
                }
                catch
                {
                    this.ProcessIndex = i + 1;
                    return false;
                }
            }

            return true;
        }


        public void stop()
        {
            // First I terminate all programs correctly
            this.terminateProgramms();
            // Then I close remaining programs by force
            if (this.pids != null)
            {
                foreach (int pid in this.pids)
                {
                    if (pid != 0)
                    {
                        this.KillProcessAndChildren(pid);
                    }
                }
            }
        }
        public void terminateProgramms()
        {
            string[] files = Properties.Settings.Default.FilesTerminate.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string[] args = Properties.Settings.Default.ArgumentsTerminate.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string[] envs = Properties.Settings.Default.EnvironmentVariables.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string file; string arg;
            
            for (int i = 0; i < files.Length; i++)
            {
                file = files.Length >= i + 1 ? files[i] : "";
                arg = args.Length >= i + 1 ? args[i] : "";
                if (file.Length == 0) continue;
                try
                {
                    this.StartProcess(file, arg, envs);
                }
                catch
                {

                }
            }
        }


        /// <summary>Start a new process.</summary>
        /// <param name="process">Path to file, which should run.</param>
        /// <param name="arguments"> Arguments.</param>
        /// <param name="s_envs"> Envelope variable list (format: "var_name=var_value").</param>
        /// <returns>Process ID or 0 if fail.</returns>
        public int StartProcess(string process, string arguments, string[] s_envs)
        {
            Process Proc = new Process();

            Proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(process)); //Process Directory
            Proc.StartInfo.FileName = Path.GetFileNameWithoutExtension(process); //Process FileName
            Proc.StartInfo.Arguments = arguments; //Process optional arguments

            OrderedDictionary od_env = this.parseEnv(s_envs);
            foreach(string key in od_env.Keys) {
                System.Environment.SetEnvironmentVariable(key, od_env[key].ToString(), EnvironmentVariableTarget.Process);
            }

            Proc.StartInfo.CreateNoWindow = true; //Set no display windows
            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Set no display any window
            
            try {
                Proc.Start();
            } catch {
                return 0;
            }

            return Proc.Id;
        }


        /// <summary>Kill a process, and all of its children, grandchildren, etc.</summary>
        /// <param name="pid">Process ID.</param>
        public void KillProcessAndChildren(int pid)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }


        /// <summary>
        /// parse the env. vars from string with "=" to assoc array
        /// </summary>
        /// <param name="envs">List of name and value of envelope variable.
        /// Format("var_name=var_value")</param>
        /// <returns>associative array of names and values</returns>
 
        public OrderedDictionary parseEnv(string[] envs)
        {
            OrderedDictionary result = new OrderedDictionary();
            string[] keyAndValue;
            foreach (string str in envs)
            {
                keyAndValue = str.Split(new string[] { "=" }, StringSplitOptions.None);
                if (keyAndValue.Length == 2) {
                    result[keyAndValue[0]] = keyAndValue[1];
                }
            }
            return result;
        }


        // checking existing of all processes
        public string checkProcessesExists()
        {
            string[] files = Properties.Settings.Default.Files.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string processName; Process process;
            int i;

            for (i = 0; i < files.Length; i++)
            {
                processName = Path.GetFileNameWithoutExtension(files[i]);

                if (i > this.pids.Length - 1)
                    return processName;

                try {
                    process = Process.GetProcessById(Convert.ToInt32(this.pids[i]));
                } catch {
                    return processName+" (PID="+this.pids[i]+")";
                }
            }
            
            return "";
        }
        
    }
}
