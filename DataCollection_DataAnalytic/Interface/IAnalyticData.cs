using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyticsDataCollection_DataAnalytic.Interface
{
    public interface IAnalyticData<TEntity> : IDisposable
        where TEntity : class
    {     
        List<string> AnalyticsMethod(string BoardStream);
    }
}
