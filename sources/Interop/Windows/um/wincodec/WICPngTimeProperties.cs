// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICPngTimeProperties : uint
    {
        WICPngTimeYear = 0x1,
        WICPngTimeMonth = 0x2,
        WICPngTimeDay = 0x3,
        WICPngTimeHour = 0x4,
        WICPngTimeMinute = 0x5,
        WICPngTimeSecond = 0x6,
        WICPngTimeProperties_FORCE_DWORD = 0x7fffffff,
    }
}
