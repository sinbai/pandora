using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.NamespacesPrivateLinkResources
{
    internal class Definition : ApiDefinition
    {
        public string Name => "NamespacesPrivateLinkResources";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new PrivateLinkResourcesGetOperation(),
        };
    }
}
