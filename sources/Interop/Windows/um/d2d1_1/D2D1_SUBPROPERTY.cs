// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_SUBPROPERTY : uint
    {
        D2D1_SUBPROPERTY_DISPLAYNAME = 0x80000000,
        D2D1_SUBPROPERTY_ISREADONLY = 0x80000001,
        D2D1_SUBPROPERTY_MIN = 0x80000002,
        D2D1_SUBPROPERTY_MAX = 0x80000003,
        D2D1_SUBPROPERTY_DEFAULT = 0x80000004,
        D2D1_SUBPROPERTY_FIELDS = 0x80000005,
        D2D1_SUBPROPERTY_INDEX = 0x80000006,
        D2D1_SUBPROPERTY_FORCE_DWORD = 0xffffffff,
    }
}
