using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.BloggerEmailDataColleciontService
{
    class BloggerAnalytics : IAnalyticData
    {
        List<_Data> Data;
        List<string> IAnalyticData.AnalyticsMethod(string BoardStream)
        {
            throw new NotImplementedException();
        }

        public List<_Data> Analyitcs(ref List<string> BoardStreams)
        {
            Data = new List<_Data>();

            for (int i = 0; i < BoardStreams.Count; i++)
            {
                ///Get blog name
                int StartIndex = BoardStreams[i].IndexOf("\"blog_name\":");

                if (StartIndex < 0) continue;

                int EndIndex = BoardStreams[i].IndexOf(",", StartIndex);

                _Data _data = new _Data();
                int ii = BoardStreams[i].Length;
                _data.Name= BoardStreams[i].Substring(StartIndex,EndIndex  - StartIndex);

                ///Get Email
                int EmailEndIndex = BoardStreams[i].IndexOf("@gmail.com");

                if (EmailEndIndex < 0)
                {
                    Data.Add(_data);
                    continue;
                }

                int EmailStartIndex = BoardStreams[i].LastIndexOf(">", EmailEndIndex);

                _data.Email = BoardStreams[i].Substring(EmailStartIndex, EmailEndIndex - EmailStartIndex) +"@gmail.com";




                Data.Add(_data);
                
            }

            return Data;
        }
    }

    public class _Data
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
