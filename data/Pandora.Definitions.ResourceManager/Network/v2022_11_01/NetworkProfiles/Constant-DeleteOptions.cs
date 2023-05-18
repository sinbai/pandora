using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.NetworkProfiles;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeleteOptionsConstant
{
    [Description("Delete")]
    Delete,

    [Description("Detach")]
    Detach,
}
