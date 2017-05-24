﻿using System;
using Foundatio.Logging;

namespace Foundatio.Metrics {
    public abstract class MetricsClientOptionsBase {
        public bool Buffered { get; set; } = true;
        public string Prefix { get; set; }
        public ILoggerFactory LoggerFactory { get; set; }
    }
}