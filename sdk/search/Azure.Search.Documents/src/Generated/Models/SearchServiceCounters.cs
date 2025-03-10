// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents service-level resource counters and quotas. </summary>
    public partial class SearchServiceCounters
    {

        /// <summary> Total number of documents across all indexes in the service. </summary>
        public SearchResourceCounter DocumentCounter { get; }
        /// <summary> Total number of indexes. </summary>
        public SearchResourceCounter IndexCounter { get; }
        /// <summary> Total number of indexers. </summary>
        public SearchResourceCounter IndexerCounter { get; }
        /// <summary> Total number of data sources. </summary>
        public SearchResourceCounter DataSourceCounter { get; }
        /// <summary> Total size of used storage in bytes. </summary>
        public SearchResourceCounter StorageSizeCounter { get; }
        /// <summary> Total number of synonym maps. </summary>
        public SearchResourceCounter SynonymMapCounter { get; }
        /// <summary> Total number of skillsets. </summary>
        public SearchResourceCounter SkillsetCounter { get; }
    }
}
