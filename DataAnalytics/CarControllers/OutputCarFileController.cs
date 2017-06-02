using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.CarControllers
{
    class OutputCarFileController :IOutput
    {
        public void OutputFile(ref List<string> Data)
        {
            StreamWriter sw = new StreamWriter("Data.csv");

            for (int i = 0; i < Data.Count; i++)
            {
                sw.WriteLine(Data[i]);
            }

            sw.Close();
        }
    }
}
