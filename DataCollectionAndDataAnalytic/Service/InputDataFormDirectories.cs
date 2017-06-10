using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DataCollectionAndDataAnalytic.Service
{
    class InputDataFormDirectories : IInput<List<string>>
    {
        string[] AllFile;
        List<string> AllStream;


        public  InputDataFormDirectories(string DirectoryName)
        {
            AllFile = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\" + DirectoryName);
            AllStream = new List<string>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<string> InputDataFromSource()
        {
            StreamReader sr;
            
            for (int i = 0; i < AllFile.Length; i++)
            {
                ////sr = new Stream(AllFile[i]);
                ////AllStream.Add(sr.ReadToEnd());
                ////sr.Close();
            }

            return null;
        }
    }
}
