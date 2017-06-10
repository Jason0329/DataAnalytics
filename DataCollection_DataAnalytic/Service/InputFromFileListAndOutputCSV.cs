using DataAnalytics.Interface;
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
    class InputFromFileListAndOutputCSV<T> : IInput<List<T>>, IOutput<List<T>>
    {
        string[] AllFile;
        List<string> AllStream;
        public InputFromFileListAndOutputCSV(string DirectoryName)
        {
            AllFile = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\" + DirectoryName);
            AllStream = new List<string>();
        }

        public List<T> InputDataFromSource()
        {
            return null;
        }

        public void OutputFile(List<T> Data)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
