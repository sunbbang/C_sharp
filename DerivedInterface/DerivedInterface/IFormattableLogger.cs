﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedInterface
{
    internal interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }
}
