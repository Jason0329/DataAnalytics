using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.BloggerEmailDataColleciontService
{
    class InputBloggerFileController : IInput
    {
        string[] AllFile;
        List<string> AllStream;


        public InputBloggerFileController()
        {
            AllFile = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\EmailData");
            AllStream = new List<string>();
        }

        public string GetSourceStream()
        {
            StreamReader sr;
            for (int i = 0; i < AllFile.Length; i++)
            {
                sr = new StreamReader(AllFile[i]);
                AllStream.Add(sr.ReadToEnd());
                sr.Close();
            }

            return "";
        }

        public List<string> ReturnFiles()
        {
            return AllStream;
        }
    }
}
