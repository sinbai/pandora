using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2021_08_01.DelegationSettings;

internal class UpdateOperation : Operations.PatchOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.NoContent,
        };

    public override Type? RequestObject() => typeof(PortalDelegationSettingsModel);

    public override ResourceID? ResourceId() => new ServiceId();

    public override Type? OptionsObject() => typeof(UpdateOperation.UpdateOptions);

    public override string? UriSuffix() => "/portalsettings/delegation";

    internal class UpdateOptions
    {
        [HeaderName("If-Match")]
        public string IfMatch { get; set; }
    }
}