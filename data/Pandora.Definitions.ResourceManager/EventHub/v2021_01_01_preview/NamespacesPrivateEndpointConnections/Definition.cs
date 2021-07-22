using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_01_01_preview.NamespacesPrivateEndpointConnections
{
    internal class Definition : ApiDefinition
    {
        public string ApiVersion => "2021-01-01-preview";
        public string Name => "NamespacesPrivateEndpointConnections";
        public IEnumerable<ApiOperation> Operations => new List<ApiOperation>
        {
            new PrivateEndpointConnectionsCreateOrUpdate(),
            new PrivateEndpointConnectionsDelete(),
            new PrivateEndpointConnectionsGet(),
            new PrivateEndpointConnectionsList(),
        };
    }
}
