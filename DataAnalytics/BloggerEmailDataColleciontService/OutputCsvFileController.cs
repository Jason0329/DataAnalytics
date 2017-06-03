using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.BloggerEmailDataColleciontService
{
    class OutputCsvFileController : IOutput
    {
       
        public void OutputFile(ref List<string> Data)
        {
            throw new NotImplementedException();
        }

        public void OutputData(ref List<_Data> AllData)
        {
            StreamWriter sw = new StreamWriter("BloggerData.csv");

            sw.Write("\uFEFF");
            for (int i = 0; i < AllData.Count; i++)
            {
                sw.WriteLine(AllData[i].Name+","+AllData[i].Email);
            }

            sw.Close();

        }
    }
}
