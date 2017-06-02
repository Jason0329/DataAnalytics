using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.Controllers
{
    class OutputCsvFileController :IOutput
    {
        StreamWriter sw;
        public OutputCsvFileController(string path)
        {
            sw = new StreamWriter(path, true, Encoding.UTF8);
        }

        void IOutput.OutputFile(ref List<string> Datas)
        {
            sw.WriteLine("社團名稱,連結,人數,社團簡介");
            foreach (var _data in Datas)
            {
                sw.WriteLine(_data);
            }

        }

      
    }
}
