﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.Interface
{
    public interface IInput<TEntity> : IDisposable
        where TEntity : class
    {
        TEntity InputDataFromSource();
    }
}
