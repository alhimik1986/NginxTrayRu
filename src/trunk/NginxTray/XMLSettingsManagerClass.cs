using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

// http://www.cambiaresearch.com/articles/33/how-can-i-easily-manage-an-xml-configuration-file-in-dotnet
namespace NginxTray
{
   #region -- Configuration Class --
   /// <summary>
   /// This Configuration class is basically just a set of 
   /// properties with a couple of static methods to manage
   /// the serialization to and deserialization from a
   /// simple XML file.
   /// </summary>
   [Serializable]
   public class XMLSettingsManager
   {
      string _Files;
      string _Arguments;
      string _EnvironmentVariables;
      bool _Notify;
      bool _Restart;
      string _FilesTerminate;
      string _ArgumentsTerminate;

      public XMLSettingsManager()
      {
          _Files="";
          _Arguments = "";
          _EnvironmentVariables = "";
          _Notify = false;
          _Restart = false;
          _FilesTerminate = "";
          _ArgumentsTerminate = "";
      }
      public static void Serialize(string file, XMLSettingsManager c)
      {
         System.Xml.Serialization.XmlSerializer xs 
            = new System.Xml.Serialization.XmlSerializer(c.GetType());
         StreamWriter writer = File.CreateText(file);
         xs.Serialize(writer, c);
         writer.Flush();
         writer.Close();
      }
      public static XMLSettingsManager Deserialize(string file)
      {
         System.Xml.Serialization.XmlSerializer xs 
            = new System.Xml.Serialization.XmlSerializer(
               typeof(XMLSettingsManager));
         StreamReader reader = File.OpenText(file);
         XMLSettingsManager c = (XMLSettingsManager)xs.Deserialize(reader);
         reader.Close();
         return c;
      }

      public string Files
      {
          get { return _Files; }
          set { _Files = value; }
      }

      public string Arguments
      {
          get { return _Arguments; }
          set { _Arguments = value; }
      }

      public string EnvironmentVariables
      {
          get { return _EnvironmentVariables; }
          set { _EnvironmentVariables = value; }
      }

      public bool Notify
      {
          get { return _Notify; }
          set { _Notify = value; }
      }

      public bool Restart
      {
          get { return _Restart; }
          set { _Restart = value; }
      }

      public string FilesTerminate
      {
          get { return _FilesTerminate; }
          set { _FilesTerminate = value; }
      }

      public string ArgumentsTerminate
      {
          get { return _ArgumentsTerminate; }
          set { _ArgumentsTerminate = value; }
      }


   }
   #endregion

}
