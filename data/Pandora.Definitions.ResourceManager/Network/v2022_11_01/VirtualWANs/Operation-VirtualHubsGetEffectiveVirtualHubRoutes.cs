using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.VirtualWANs;

internal class VirtualHubsGetEffectiveVirtualHubRoutesOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
                HttpStatusCode.OK,
        };

    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(EffectiveRoutesParametersModel);

    public override ResourceID? ResourceId() => new VirtualHubId();

    public override Type? ResponseObject() => typeof(VirtualHubEffectiveRouteListModel);

    public override string? UriSuffix() => "/effectiveRoutes";


}
