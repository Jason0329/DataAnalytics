using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.CarControllers
{
    class CarAnalytics:IAnalyticData
    {
        List<string> Data;

        public CarAnalytics()
        {
            Data = new List<string>();
        }

        public List<string> AnalyticsMethod(string BoardStream)
        {
            throw new NotImplementedException();
        }

        public List<string> Analyitcs(ref List<string> BoardStreams)
        {
            for (int i = 0; i < BoardStreams.Count; i++)
            {
                int StartIndex = BoardStreams[i].IndexOf(",新");

                if (StartIndex < 0) continue ;

                string _data = BoardStreams[i].Substring(StartIndex);

                for (int j = 0; j < _data.Split('\n').Length; j++)
                {
                    Data.Add(_data.Split('\n')[j]);
                }
            }

            return Data;
        }
    }
}
