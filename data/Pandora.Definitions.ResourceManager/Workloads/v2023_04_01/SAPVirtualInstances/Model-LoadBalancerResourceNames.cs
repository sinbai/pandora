using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Workloads.v2023_04_01.SAPVirtualInstances;


internal class LoadBalancerResourceNamesModel
{
    [MaxItems(1)]
    [JsonPropertyName("backendPoolNames")]
    public List<string>? BackendPoolNames { get; set; }

    [MaxItems(2)]
    [JsonPropertyName("frontendIpConfigurationNames")]
    public List<string>? FrontendIPConfigurationNames { get; set; }

    [MaxItems(2)]
    [JsonPropertyName("healthProbeNames")]
    public List<string>? HealthProbeNames { get; set; }

    [JsonPropertyName("loadBalancerName")]
    public string? LoadBalancerName { get; set; }
}