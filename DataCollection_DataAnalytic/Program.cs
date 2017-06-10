using DataCollection_DataAnalytic.Class;
using DataCollection_DataAnalytic.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection_DataAnalytic
{
    class Program
    {
        static void Main(string[] args)
        {
            InputDataFormDirectories Input = new InputDataFormDirectories("EmailData");
            OutputData<String> Output = new OutputData<String>();

            Output.OutputFile(Input.InputDataFromSource());
        }
    }
}
