using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Logic.v2019_05_01.IntegrationAccountBatchConfigurations;

internal class BatchConfigurationId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/batchConfigurations/{batchConfigurationName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftLogic", "Microsoft.Logic"),
        ResourceIDSegment.Static("staticIntegrationAccounts", "integrationAccounts"),
        ResourceIDSegment.UserSpecified("integrationAccountName"),
        ResourceIDSegment.Static("staticBatchConfigurations", "batchConfigurations"),
        ResourceIDSegment.UserSpecified("batchConfigurationName"),
    };
}
