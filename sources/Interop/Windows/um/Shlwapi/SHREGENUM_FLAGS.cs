// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SHREGENUM_FLAGS
    {
        SHREGENUM_DEFAULT = 0x00000000,
        SHREGENUM_HKCU = 0x00000001,
        SHREGENUM_HKLM = 0x00000010,
        SHREGENUM_BOTH = 0x00000011,
    }
}