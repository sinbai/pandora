using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.VirtualWANs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum IPVersionConstant
{
    [Description("IPv4")]
    IPvFour,

    [Description("IPv6")]
    IPvSix,
}
