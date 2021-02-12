// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DWRITE_PANOSE_MIDLINE
    {
        DWRITE_PANOSE_MIDLINE_ANY = 0,
        DWRITE_PANOSE_MIDLINE_NO_FIT = 1,
        DWRITE_PANOSE_MIDLINE_STANDARD_TRIMMED = 2,
        DWRITE_PANOSE_MIDLINE_STANDARD_POINTED = 3,
        DWRITE_PANOSE_MIDLINE_STANDARD_SERIFED = 4,
        DWRITE_PANOSE_MIDLINE_HIGH_TRIMMED = 5,
        DWRITE_PANOSE_MIDLINE_HIGH_POINTED = 6,
        DWRITE_PANOSE_MIDLINE_HIGH_SERIFED = 7,
        DWRITE_PANOSE_MIDLINE_CONSTANT_TRIMMED = 8,
        DWRITE_PANOSE_MIDLINE_CONSTANT_POINTED = 9,
        DWRITE_PANOSE_MIDLINE_CONSTANT_SERIFED = 10,
        DWRITE_PANOSE_MIDLINE_LOW_TRIMMED = 11,
        DWRITE_PANOSE_MIDLINE_LOW_POINTED = 12,
        DWRITE_PANOSE_MIDLINE_LOW_SERIFED = 13,
    }
}
