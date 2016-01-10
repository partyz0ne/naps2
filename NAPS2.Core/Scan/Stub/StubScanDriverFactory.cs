﻿using System;
using System.Collections.Generic;
using System.Linq;
using NAPS2.Scan.Images;

namespace NAPS2.Scan.Stub
{
    public class StubScanDriverFactory : IScanDriverFactory
    {
        public IScanDriver Create(string driverName)
        {
            return new StubScanDriver(driverName);
        }
    }
}
