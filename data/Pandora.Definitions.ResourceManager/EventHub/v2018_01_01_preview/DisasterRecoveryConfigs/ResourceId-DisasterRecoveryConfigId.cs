using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.DisasterRecoveryConfigs
{
    internal class DisasterRecoveryConfigId : ResourceID
    {
        public string ID() => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}";
    }
}
