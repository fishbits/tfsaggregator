using System;
using System.Collections.Generic;

using Aggregator.Core;
using Aggregator.Core.Configuration;
using Aggregator.Core.Context;
using Aggregator.Core.Interfaces;
using Aggregator.Core.Monitoring;

namespace UnitTests.Core.Mock
{
    internal class RuntimeContextMock : IRuntimeContext
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public bool HasErrors { get; }

        public IEnumerator<string> Errors { get; }

        public IRequestContext RequestContext { get; }

        public string SettingsPath { get; }

        public TFSAggregatorSettings Settings { get; }

        public ILogEvents Logger { get; }

        public IWorkItemRepository WorkItemRepository { get; }

        public ScriptEngine GetEngine()
        {
            throw new NotImplementedException();
        }

        public RateLimiter RateLimiter { get; }
    }
}