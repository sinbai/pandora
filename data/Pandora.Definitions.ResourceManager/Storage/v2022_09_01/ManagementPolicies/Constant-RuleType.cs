using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Storage.v2022_09_01.ManagementPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RuleTypeConstant
{
    [Description("Lifecycle")]
    Lifecycle,
}