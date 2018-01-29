﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostic.DataProviders
{
    public class DiagnosticDataProvider
    {
        private OperationDataCache _cache;

        public DiagnosticDataProvider(OperationDataCache cache)
        {
            _cache = cache;
        }

        protected Task<T> GetOrAddFromCache<T>(string key, Func<string, CacheMember> addFunction)
        {
            return Convert.ChangeType(_cache.GetOrAdd(key, addFunction), typeof(Task<T>)) as Task<T>;
        }
    }
}