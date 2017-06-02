using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.Process
{
    class output
    {
        string _path;
        private IOutput _OutputService;
        public output(IOutput OutputService)
        {
            this._OutputService = OutputService;
        }

        public void Run(ref List<string> Data)
        {
            _OutputService.OutputFile(ref Data);
        }

    }
}
