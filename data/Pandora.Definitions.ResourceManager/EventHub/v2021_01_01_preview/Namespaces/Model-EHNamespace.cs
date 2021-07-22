using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_01_01_preview.Namespaces
{

    internal class EHNamespace
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("identity")]
        public Identity? Identity { get; set; }

        [JsonPropertyName("location")]
        public CustomTypes.Location? Location { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("properties")]
        public EHNamespaceProperties? Properties { get; set; }

        [JsonPropertyName("sku")]
        public Sku? Sku { get; set; }

        [JsonPropertyName("systemData")]
        public SystemData? SystemData { get; set; }

        [JsonPropertyName("tags")]
        public CustomTypes.Tags? Tags { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
