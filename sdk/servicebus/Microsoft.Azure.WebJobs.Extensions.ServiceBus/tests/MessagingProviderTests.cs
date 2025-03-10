﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.WebJobs.ServiceBus.UnitTests
{
    public class MessagingProviderTests
    {
        private static string _defaultConnection = "Endpoint=sb://default.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=abc123=";
        private static ServiceBusClient _client = new(_defaultConnection);

        [Test]
        public void CreateMessageReceiver_ReturnsExpectedReceiver()
        {
            var options = new ServiceBusOptions();
            var configuration = CreateConfiguration(new KeyValuePair<string, string>("connection", _defaultConnection));

            var provider = new MessagingProvider(new OptionsWrapper<ServiceBusOptions>(options));

            var receiver = provider.CreateBatchMessageReceiver(_client, "entityPath");
            Assert.AreEqual("entityPath", receiver.EntityPath);

            var receiver2 = provider.CreateBatchMessageReceiver(_client, "entityPath");
            Assert.AreSame(receiver, receiver2);

            options.PrefetchCount = 100;
            receiver = provider.CreateBatchMessageReceiver(_client, "entityPath1");
            Assert.AreEqual(100, receiver.PrefetchCount);
        }

        [Test]
        public void CreateProcessor_ReturnsExpectedProcessor()
        {
            var options = new ServiceBusOptions();
            var configuration = CreateConfiguration(new KeyValuePair<string, string>("connection", _defaultConnection));
            var provider = new MessagingProvider(new OptionsWrapper<ServiceBusOptions>(options));

            var processor = provider.CreateProcessor(_client, "entityPath");
            Assert.AreEqual("entityPath", processor.EntityPath);

            var processor2 = provider.CreateProcessor(_client, "entityPath");
            Assert.AreNotSame(processor, processor2);

            options.PrefetchCount = 100;
            options.MaxConcurrentCalls = 5;
            options.MaxAutoLockRenewalDuration = TimeSpan.FromSeconds(30);
            processor = provider.CreateProcessor(_client, "entityPath1");
            Assert.AreEqual(options.PrefetchCount, processor.PrefetchCount);
            Assert.AreEqual(options.MaxConcurrentCalls, processor.MaxConcurrentCalls);
            Assert.AreEqual(options.MaxAutoLockRenewalDuration, processor.MaxAutoLockRenewalDuration);
        }

        [Test]
        public void CreateMessageSender_ReturnsExpectedSender()
        {
            string defaultConnection = "Endpoint=sb://default.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=abc123=";
            var options = new ServiceBusOptions();

            var configuration = CreateConfiguration(new KeyValuePair<string, string>("connection", defaultConnection));
            var provider = new MessagingProvider(new OptionsWrapper<ServiceBusOptions>(options));

            var sender = provider.CreateMessageSender(_client, "entityPath");
            Assert.AreEqual("entityPath", sender.EntityPath);

            var sender2 = provider.CreateMessageSender(_client, "entityPath");
            Assert.AreSame(sender, sender2);
        }

        private IConfiguration CreateConfiguration(params KeyValuePair<string, string>[] data)
        {
            return new ConfigurationBuilder().AddInMemoryCollection(data).Build();
        }
    }
}
