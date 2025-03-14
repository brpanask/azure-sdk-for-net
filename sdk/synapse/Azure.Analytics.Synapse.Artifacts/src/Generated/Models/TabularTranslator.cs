// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity tabular translator. </summary>
    public partial class TabularTranslator : CopyTranslator
    {
        /// <summary> Initializes a new instance of TabularTranslator. </summary>
        public TabularTranslator()
        {
            Type = "TabularTranslator";
        }

        /// <summary> Initializes a new instance of TabularTranslator. </summary>
        /// <param name="type"> Copy translator type. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="columnMappings"> Column mappings. Example: &quot;UserId: MyUserId, Group: MyGroup, Name: MyName&quot; Type: string (or Expression with resultType string). This property will be retired. Please use mappings property. </param>
        /// <param name="schemaMapping"> The schema mapping to map between tabular data and hierarchical data. Example: {&quot;Column1&quot;: &quot;$.Column1&quot;, &quot;Column2&quot;: &quot;$.Column2.Property1&quot;, &quot;Column3&quot;: &quot;$.Column2.Property2&quot;}. Type: object (or Expression with resultType object). This property will be retired. Please use mappings property. </param>
        /// <param name="collectionReference"> The JSON Path of the Nested Array that is going to do cross-apply. Type: object (or Expression with resultType object). </param>
        /// <param name="mapComplexValuesToString"> Whether to map complex (array and object) values to simple strings in json format. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="mappings"> Column mappings with logical types. Tabular-&gt;tabular example: [{&quot;source&quot;:{&quot;name&quot;:&quot;CustomerName&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientName&quot;,&quot;type&quot;:&quot;String&quot;}},{&quot;source&quot;:{&quot;name&quot;:&quot;CustomerAddress&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientAddress&quot;,&quot;type&quot;:&quot;String&quot;}}].  Hierarchical-&gt;tabular example: [{&quot;source&quot;:{&quot;path&quot;:&quot;$.CustomerName&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientName&quot;,&quot;type&quot;:&quot;String&quot;}},{&quot;source&quot;:{&quot;path&quot;:&quot;$.CustomerAddress&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientAddress&quot;,&quot;type&quot;:&quot;String&quot;}}]. Type: object (or Expression with resultType object). </param>
        /// <param name="typeConversion"> Whether to enable the advanced type conversion feature in the Copy activity. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="typeConversionSettings"> Type conversion settings. </param>
        internal TabularTranslator(string type, IDictionary<string, object> additionalProperties, object columnMappings, object schemaMapping, object collectionReference, object mapComplexValuesToString, object mappings, object typeConversion, TypeConversionSettings typeConversionSettings) : base(type, additionalProperties)
        {
            ColumnMappings = columnMappings;
            SchemaMapping = schemaMapping;
            CollectionReference = collectionReference;
            MapComplexValuesToString = mapComplexValuesToString;
            Mappings = mappings;
            TypeConversion = typeConversion;
            TypeConversionSettings = typeConversionSettings;
            Type = type ?? "TabularTranslator";
        }

        /// <summary> Column mappings. Example: &quot;UserId: MyUserId, Group: MyGroup, Name: MyName&quot; Type: string (or Expression with resultType string). This property will be retired. Please use mappings property. </summary>
        public object ColumnMappings { get; set; }
        /// <summary> The schema mapping to map between tabular data and hierarchical data. Example: {&quot;Column1&quot;: &quot;$.Column1&quot;, &quot;Column2&quot;: &quot;$.Column2.Property1&quot;, &quot;Column3&quot;: &quot;$.Column2.Property2&quot;}. Type: object (or Expression with resultType object). This property will be retired. Please use mappings property. </summary>
        public object SchemaMapping { get; set; }
        /// <summary> The JSON Path of the Nested Array that is going to do cross-apply. Type: object (or Expression with resultType object). </summary>
        public object CollectionReference { get; set; }
        /// <summary> Whether to map complex (array and object) values to simple strings in json format. Type: boolean (or Expression with resultType boolean). </summary>
        public object MapComplexValuesToString { get; set; }
        /// <summary> Column mappings with logical types. Tabular-&gt;tabular example: [{&quot;source&quot;:{&quot;name&quot;:&quot;CustomerName&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientName&quot;,&quot;type&quot;:&quot;String&quot;}},{&quot;source&quot;:{&quot;name&quot;:&quot;CustomerAddress&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientAddress&quot;,&quot;type&quot;:&quot;String&quot;}}].  Hierarchical-&gt;tabular example: [{&quot;source&quot;:{&quot;path&quot;:&quot;$.CustomerName&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientName&quot;,&quot;type&quot;:&quot;String&quot;}},{&quot;source&quot;:{&quot;path&quot;:&quot;$.CustomerAddress&quot;,&quot;type&quot;:&quot;String&quot;},&quot;sink&quot;:{&quot;name&quot;:&quot;ClientAddress&quot;,&quot;type&quot;:&quot;String&quot;}}]. Type: object (or Expression with resultType object). </summary>
        public object Mappings { get; set; }
        /// <summary> Whether to enable the advanced type conversion feature in the Copy activity. Type: boolean (or Expression with resultType boolean). </summary>
        public object TypeConversion { get; set; }
        /// <summary> Type conversion settings. </summary>
        public TypeConversionSettings TypeConversionSettings { get; set; }
    }
}
