// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum EC_SUBSCRIPTION_CONFIGURATION_MODE
    {
        EcConfigurationModeNormal = 0,
        EcConfigurationModeCustom,
        EcConfigurationModeMinLatency,
        EcConfigurationModeMinBandwidth,
    }
}