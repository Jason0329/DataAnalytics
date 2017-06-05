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
                int StartIndex = BoardStreams[i].IndexOf("target=\"_blank\" href=\"https://www.pixnet.net/blog/profile");

                if (StartIndex < 0) continue;

                int EndIndex = BoardStreams[i].IndexOf("\">", StartIndex);

                _Data _data = new _Data();
                int ii = BoardStreams[i].Length;
                _data.Name= BoardStreams[i].Substring(StartIndex,EndIndex  - StartIndex);

                string EmailDomain= "@yahoo.com.tw";

                ///Get Email
                int EmailEndIndex = BoardStreams[i].IndexOf("@yahoo.com.tw");

                if (EmailEndIndex < 0)
                {
                    EmailEndIndex = BoardStreams[i].IndexOf("@gmail.com");
                    EmailDomain = "@gmail.com";
                }
                if (EmailEndIndex < 0)
                {
                    EmailEndIndex = BoardStreams[i].IndexOf("@hotmail.com");
                    EmailDomain = "@hotmail.com";
                }
                if (EmailEndIndex < 0)
                {
                    EmailEndIndex = BoardStreams[i].IndexOf("@outlook");
                    EmailDomain = "@outlook.askfdjljla";
                }
                if (EmailEndIndex < 0)
                {
                    EmailEndIndex = BoardStreams[i].IndexOf("@kimo.com");
                    EmailDomain = "@kimo.com";
                }
                if (EmailEndIndex < 0)
                {
                    EmailEndIndex = BoardStreams[i].IndexOf("@msa");
                    EmailDomain = "@outlook.askfdjljla";
                }
                if (EmailEndIndex < 0)
                {
                    Data.Add(_data);
                    continue;
                }

                int EmailStartIndex=0;//= BoardStreams[i].LastIndexOf(">", EmailEndIndex);

                for (int j = EmailEndIndex-1; j > 0; j--)
                {
                    if(!IsNatural_Number(BoardStreams[i][j].ToString()))
                    {
                        EmailStartIndex = j;
                        break;
                    }
                }

                _data.Email = BoardStreams[i].Substring(EmailStartIndex +1, EmailEndIndex-EmailStartIndex + EmailDomain.Length) ;




                Data.Add(_data);
                
            }

            return Data;
        }

        public bool IsNatural_Number(string str)
        {

            System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[A-Za-z_0-9\.\-]");
            //System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"[\\w-]+(\\.[\\w-]+)*@[\\w-]+(\\.[\\w-]+)+$");

            return reg1.IsMatch(str);

        }
    }

    public class _Data
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
