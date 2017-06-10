using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.Interface
{
    public interface IOutput
    {
        void OutputFile(ref List<string> Data);
    }
}
