using System.ComponentModel;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.v2019_10_01.Store
{
    internal class Sku
    {
        [JsonPropertyName("name")]
        public SkuName Name { get; set; }

        [ConstantType(ConstantTypeAttribute.ConstantType.String)]
        internal enum SkuName
        {
            [Description("free")]
            Free,

            [Description("standard")]
            Standard
        }
    }
}