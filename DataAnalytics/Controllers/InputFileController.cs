using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.Controllers
{
    class InputFileController:IInput
    {
        StreamReader sr;
        public InputFileController(string FileSource)
        {
            sr = new StreamReader(FileSource);
        }

        string IInput.GetSourceStream()
        {
            return sr.ReadToEnd();
        }

        ~InputFileController()
        {
            sr.Close();
            sr.Dispose();
        }
    }
}
