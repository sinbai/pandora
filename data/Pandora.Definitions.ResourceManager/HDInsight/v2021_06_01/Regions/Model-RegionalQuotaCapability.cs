using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HDInsight.v2021_06_01.Regions;


internal class RegionalQuotaCapabilityModel
{
    [JsonPropertyName("coresAvailable")]
    public int? CoresAvailable { get; set; }

    [JsonPropertyName("coresUsed")]
    public int? CoresUsed { get; set; }

    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}
