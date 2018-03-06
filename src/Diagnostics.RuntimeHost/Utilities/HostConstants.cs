﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostics.RuntimeHost.Utilities
{
    internal class HostConstants
    {
        internal const string RegistryRootPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\IIS Extensions\Web Hosting Framework";

        internal const string ScriptSourceConfigRegistryRootPath = RegistryRootPath + @"\ScriptSourceConfig";

        internal const string LocalSourceDirectoryKey = "LocalSourceDirectory";
        
        // Ideally, this should move to Data Providers

        public static TimeSpan KustoDataRetentionPeriod = TimeSpan.FromDays(-30);

        public static TimeSpan KustoDataLatencyPeriod = TimeSpan.FromMinutes(15);

        public const int DefaultTimeGrainInMinutes = 5;

        public const string KustoTimeFormat = "yyyy-MM-dd HH:mm:ss";

        #region Time Grain Constants

        internal static List<Tuple<TimeSpan, TimeSpan, bool>> TimeGrainOptions = new List<Tuple<TimeSpan, TimeSpan, bool>>
            {
                // 5 minute grain - max time range 1 day
                new Tuple<TimeSpan, TimeSpan, bool>(TimeSpan.FromMinutes(5), TimeSpan.FromDays(1), true),

                // 30 minute grain - max time range 3 days
                new Tuple<TimeSpan, TimeSpan, bool>(TimeSpan.FromMinutes(30), TimeSpan.FromDays(3),  false),
                
                // 1 hour grain - max time range 7 days
                new Tuple<TimeSpan, TimeSpan, bool>(TimeSpan.FromHours(1), TimeSpan.FromDays(7), false),
            };

        #endregion
    }

    internal class CompilerHostConstants
    {
        internal const int Port = 7000;
        internal const int PollIntervalInMs = 1 * 60 * 1000;
        internal const long ProcessMemoryThresholdInBytes = 300 * 1024 * 1024; // 300 MB 
    }
}
