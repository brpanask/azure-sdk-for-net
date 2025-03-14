// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Unsubscribe event trigger from events. </summary>
    public partial class TriggerUnsubscribeTriggerFromEventsOperation : Operation<TriggerSubscriptionOperationStatus>, IOperationSource<TriggerSubscriptionOperationStatus>
    {
        private readonly ArmOperationHelpers<TriggerSubscriptionOperationStatus> _operation;

        /// <summary> Initializes a new instance of TriggerUnsubscribeTriggerFromEventsOperation for mocking. </summary>
        protected TriggerUnsubscribeTriggerFromEventsOperation()
        {
        }

        internal TriggerUnsubscribeTriggerFromEventsOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<TriggerSubscriptionOperationStatus>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "TriggerUnsubscribeTriggerFromEventsOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override TriggerSubscriptionOperationStatus Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TriggerSubscriptionOperationStatus>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TriggerSubscriptionOperationStatus>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        TriggerSubscriptionOperationStatus IOperationSource<TriggerSubscriptionOperationStatus>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return TriggerSubscriptionOperationStatus.DeserializeTriggerSubscriptionOperationStatus(document.RootElement);
        }

        async ValueTask<TriggerSubscriptionOperationStatus> IOperationSource<TriggerSubscriptionOperationStatus>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return TriggerSubscriptionOperationStatus.DeserializeTriggerSubscriptionOperationStatus(document.RootElement);
        }
    }
}
