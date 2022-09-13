﻿using System.Diagnostics;

namespace Khepri.AssetDelivery
{
    public class Debug
    {
        [Conditional("DEBUG")]
        public static void LogFormat(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(format, args);
        }
    }
}
