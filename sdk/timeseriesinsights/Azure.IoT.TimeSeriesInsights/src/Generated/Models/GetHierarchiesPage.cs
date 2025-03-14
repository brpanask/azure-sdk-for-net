// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Partial list of time series hierarchies returned in a single request. </summary>
    public partial class GetHierarchiesPage : PagedResponse
    {
        /// <summary> Initializes a new instance of GetHierarchiesPage. </summary>
        internal GetHierarchiesPage()
        {
            Hierarchies = new ChangeTrackingList<TimeSeriesHierarchy>();
        }

        /// <summary> Initializes a new instance of GetHierarchiesPage. </summary>
        /// <param name="continuationToken"> If returned, this means that current results represent a partial result. Continuation token allows to get the next page of results. To get the next page of query results, send the same request with continuation token parameter in &quot;x-ms-continuation&quot; HTTP header. </param>
        /// <param name="hierarchies"> Partial list of time series hierarchies returned in a single request. Can be empty if server was unable to fill the page in this request, or there is no more objects when continuation token is null. </param>
        internal GetHierarchiesPage(string continuationToken, IReadOnlyList<TimeSeriesHierarchy> hierarchies) : base(continuationToken)
        {
            Hierarchies = hierarchies;
        }

        /// <summary> Partial list of time series hierarchies returned in a single request. Can be empty if server was unable to fill the page in this request, or there is no more objects when continuation token is null. </summary>
        public IReadOnlyList<TimeSeriesHierarchy> Hierarchies { get; }
    }
}
