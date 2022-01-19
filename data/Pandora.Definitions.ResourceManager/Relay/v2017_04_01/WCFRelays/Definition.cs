using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Relay.v2017_04_01.WCFRelays
{
    internal class Definition : ApiDefinition
    {
        public string Name => "WCFRelays";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new CreateOrUpdateOperation(),
            new CreateOrUpdateAuthorizationRuleOperation(),
            new DeleteOperation(),
            new DeleteAuthorizationRuleOperation(),
            new GetOperation(),
            new GetAuthorizationRuleOperation(),
            new ListAuthorizationRulesOperation(),
            new ListByNamespaceOperation(),
            new ListKeysOperation(),
            new RegenerateKeysOperation(),
        };
    }
}
