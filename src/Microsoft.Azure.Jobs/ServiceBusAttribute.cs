﻿using System;
using System.Diagnostics;

namespace Microsoft.Azure.Jobs
{
    /// <summary>Binds to Azure Service Bus Queues and Topics.</summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    [DebuggerDisplay("{QueueOrTopicName,nq}")]
    public sealed class ServiceBusAttribute : Attribute
    {
        private readonly string _queueOrTopicName;

        /// <summary>Initializes a new instance of the <see cref="ServiceBusAttribute"/> class.</summary>
        /// <param name="queueOrTopicName">The name of the queue or topic to which to bind.</param>
        public ServiceBusAttribute(string queueOrTopicName)
        {
            _queueOrTopicName = queueOrTopicName;
        }

        /// <summary>Gets the name of the queue or topic to which to bind.</summary>
        public string QueueOrTopicName
        {
            get { return _queueOrTopicName; }
        }
    }
}