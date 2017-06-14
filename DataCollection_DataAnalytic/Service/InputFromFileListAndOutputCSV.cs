using DataAnalytics.Interface;
using DataAnalyticsDataCollection_DataAnalytic.Interface;
using DataCollection_DataAnalytic.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection_DataAnalytic.Service
{
    class InputFromFileListAndOutputCSV<T> : IInput<List<T>>, IOutput<List<T>> , IAnalyticData<string>
    {
        string[] AllFile;
        string OutputFileName;
        List<string> AllStream;
        public InputFromFileListAndOutputCSV(string _DirectoryName , string _OutputFileName)
        {
            this.AllFile = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\" + _DirectoryName);
            this.AllStream = new List<string>();
            this.OutputFileName = _OutputFileName;
        }

        public virtual List<T> InputDataFromSource()
        {
            StreamReader sr;

            for (int i = 0; i < AllFile.Length; i++)
            {
                sr = new StreamReader(AllFile[i]);
                AllStream.Add(sr.ReadToEnd());
                Console.WriteLine(AllFile[i]);
                sr.Close();
            }

            return null;
        }

        public virtual void OutputFile(List<T> Data)
        {
            Type DataType = Data[0].GetType();
            StreamWriter sw = new StreamWriter("Data.csv");

            string WriteLine = "";



            for (int i = 0; i < Data.Count; i++)
            {

                string tt = Data[i].GetType().Name;
                switch (Data[i].GetType().Name)
                {
                    case "String":
                        WriteLine = Data[i].ToString();
                        break;
                }

                sw.WriteLine(WriteLine);

            }

            sw.Close();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<string> AnalyticsMethod(string BoardStream)
        {
            throw new NotImplementedException();
        }
    }
}
