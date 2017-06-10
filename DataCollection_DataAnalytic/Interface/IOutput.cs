using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection_DataAnalytic.Interface
{
    public interface IOutput<TEntity> : IDisposable
        where TEntity : class
    {
        void OutputFile(TEntity Data);
    }
}
