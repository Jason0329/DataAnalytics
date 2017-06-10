using DataCollection_DataAnalytic.Class;
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
    class OutputData<T> : IOutput<List<T>>
        where T : class 
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OutputFile(List<T> Data)
        {
            Type DataType = Data[0].GetType();
            StreamWriter sw = new StreamWriter("Data.csv");

            string WriteLine="";



            for (int i = 0; i < Data.Count; i++)
            {

                //if (Data[i] is string)
                //{
                //    WriteLine = Data[i].ToString();
                //}
                string tt = Data[i].GetType().Name;
                switch (Data[i].GetType().Name)
                {
                    case "String":
                        WriteLine = Data[i].ToString();
                        break;
                }
                
                //PropertyInfo[] AllProperty = Data[i].GetType().GetProperties();

                //foreach (var _property in AllProperty)
                //{
                //    WriteLine = _property.GetValue(Data[i]).ToString() + ",";
                //}

                sw.WriteLine(WriteLine);
                
            }

            sw.Close();

        }
    }
}
