using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.AnalyticData
{
    class AnalyticsFacebook : IAnalyticData
    {
        private List<string> _Selector;
        private List<string> _Data;
        private List<string> _Link;

        public AnalyticsFacebook(ref List<string> Selector)
        {
            _Selector = Selector;
            _Data = new List<string>();
            _Link = new List<string>();
        }

        public List<string> AnalyticsMethod(string BoardStream)
        {
            GetDataBySelector(BoardStream);
            return _Data;
        }

        void GetDataBySelector(string _BoardStream )
        {
            int StartIndex = 0;
            int EndIndex = 0;
            string _Substring = "";
            string ColumnData = "";

            while (true)
            {
                for (int i = 0; i < _Selector.Count; i++)
                {
                    StartIndex = _BoardStream.IndexOf(_Selector[i], EndIndex);

                    if (StartIndex < 0)
                    {
                        return; 
                    }

                    if (_Selector[i].Contains("_52eh _5bcu"))
                    {
                        EndIndex = _BoardStream.IndexOf("</div>", StartIndex);
                    }
                    else
                    {
                        EndIndex = _BoardStream.IndexOf("</", StartIndex);
                    }
                    _Substring = _BoardStream.Substring(StartIndex, EndIndex - StartIndex + 2);
                    //GetSubString(_BoardStream, StartIndex, EndIndex);
                    ColumnData += GetSubStringData(_Substring).Replace("<span>", "").Replace(",", "").Replace("\n", "").Replace("\r", "").Replace("@+", ",").Trim() + ",";
                }
                ColumnData = ColumnData.Trim(',');

                _Data.Add(ColumnData);

                ColumnData = "";
            }
        }

        string GetSubStringData(string _SubString)
        {

            if (_SubString.Contains("_52eh _5bcu"))
            {
                _SubString = _SubString.Replace("<span>", "").Replace("</span>", "\r\n").Replace("<wbr><span class=\"word_break\">","").Replace("_52eh _5bcu\">","").Replace("</","");
                return _SubString;
            }


            int StartIndex = _SubString.LastIndexOf("\">");
            int EndIndex = _SubString.LastIndexOf("<");

            string ReturnString = "";

            if (EndIndex < 0)
                ReturnString = _SubString.Substring(StartIndex + 2);
            else
                ReturnString = _SubString.Substring(StartIndex + 2, EndIndex - StartIndex - 2);

            if (_SubString.Contains("href=\""))
            {
                StartIndex = _SubString.IndexOf("<a href=\"");
                EndIndex = _SubString.LastIndexOf("data-testid");
                ReturnString += "@+ "+"https://www.facebook.com" + _SubString.Substring(StartIndex + 9, EndIndex - StartIndex - 9).Trim().Trim('"');
            }

            return ReturnString;
        }

       
    }
}

