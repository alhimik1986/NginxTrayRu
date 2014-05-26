using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;

namespace NginxTray
{
    public class ProcessManagement
    {
        // the index of string in textBoxFiles
        public int ProcessIndex;

        //Start a new process
        public bool StartProcess(string process, string arguments, string[] s_envs)
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

        public bool start()
        {
            string[] files = Properties.Settings.Default.Files.Split(                new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string[] args  = Properties.Settings.Default.Arguments.Split(            new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string[] envs  = Properties.Settings.Default.EnvironmentVariables.Split (new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            
            string file; string arg;

            for (int i = 0; i < files.Length; i++)
            {
                file = files.Length >= i+1 ? files[i] : "";
                arg  = args.Length  >= i+1 ? args[i]  : "";
                if (file.Length == 0) continue;
                try
                {
                    if ( ! this.StartProcess(file, arg, envs))
                    {
                        this.ProcessIndex = i+1;
                        return false;
                    }
                }
                catch
                {
                    this.ProcessIndex = i+1;
                    return false;
                }
            }

            return true;
        }


        // parse the env. vars from string with "=" to assoc array
        public OrderedDictionary parseEnv(string[] strings)
        {
            OrderedDictionary result = new OrderedDictionary();
            string[] keyAndValue;
            foreach (string str in strings) {
                keyAndValue = str.Split(new string[] { "=" }, StringSplitOptions.None);
                if (keyAndValue.Length == 2) {
                    result[keyAndValue[0]] = keyAndValue[1];
                }
            }
            return result;
        }


        public void stop()
        {
            string[] files = Properties.Settings.Default.Files.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            foreach (string file in files) {
                this.StopProcess(file);
            }
        }


        // checking existing of all processes
        public string checkProcessesExists()
        {
            string[] files = Properties.Settings.Default.Files.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            string process; Process[] processgroup;
            foreach (string file in files)
            {
                process = Path.GetFileNameWithoutExtension(file);
                processgroup = Process.GetProcessesByName(process);
                if (processgroup == null || processgroup.Length == 0)
                {
                    return process;
                }
            }

            return "";
        }
        
    }
}
