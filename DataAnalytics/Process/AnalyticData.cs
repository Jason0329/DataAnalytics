using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.Process
{
    class AnalyticData
    {
        private IAnalyticData _AnalyticDataService;
        public AnalyticData(IAnalyticData AnalyticDataService)
        {
            this._AnalyticDataService = AnalyticDataService;
        }

    }
}
