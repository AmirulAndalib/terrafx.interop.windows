// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WIC8BIMIptcProperties : uint
    {
        WIC8BIMIptcPString = 0,
        WIC8BIMIptcEmbeddedIPTC = 0x1,
        WIC8BIMIptcProperties_FORCE_DWORD = 0x7fffffff,
    }
}
