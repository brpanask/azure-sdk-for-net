﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Communication.Sms.Tests
{
    public class SmsClientLiveTestBase : RecordedTestBase<SmsClientTestEnvironment>
    {
        public SmsClientLiveTestBase(bool isAsync) : base(isAsync)
            => Sanitizer = new SmsClientRecordedTestSanitizer();

        [OneTimeSetUp]
        public void Setup()
        {
            if (TestEnvironment.ShouldIgnoreTests)
            {
                Assert.Ignore("SMS tests are skipped " +
                    "because sms package is not included in the TEST_PACKAGES_ENABLED variable");
            }
        }

        public SmsClient CreateSmsClient()
        {
            var connectionString = TestEnvironment.LiveTestConnectionString;
            SmsClient client = new SmsClient(connectionString, InstrumentClientOptions(new SmsClientOptions()));

            #region Snippet:Azure_Communication_Sms_Tests_Samples_CreateSmsClient
            //@@var connectionString = "<connection_string>"; // Find your Communication Services resource in the Azure portal
            //@@SmsClient client = new SmsClient(connectionString);
            #endregion Snippet:Azure_Communication_Sms_Tests_Samples_CreateSmsClient
            return InstrumentClient(client);
        }

        public SmsClient CreateSmsClientWithToken()
        {
            Uri endpoint = TestEnvironment.LiveTestEndpoint;
            TokenCredential tokenCredential;
            if (Mode == RecordedTestMode.Playback)
            {
                tokenCredential = new MockCredential();
            }
            else
            {
                #region Snippet:Azure_Communication_Sms_Tests_Samples_CreateSmsClientWithToken
                //@@ string endpoint = "<endpoint_url>";
                //@@ TokenCredential tokenCredential = new DefaultAzureCredential();
                /*@@*/tokenCredential = new DefaultAzureCredential();
                //@@ SmsClient client = new SmsClient(new Uri(endpoint), tokenCredential);
                #endregion Snippet:Azure_Communication_Sms_Tests_Samples_CreateSmsClientWithToken
            }
            SmsClient client = new SmsClient(endpoint, tokenCredential, InstrumentClientOptions(new SmsClientOptions()));
            return InstrumentClient(client);
        }
    }
}
