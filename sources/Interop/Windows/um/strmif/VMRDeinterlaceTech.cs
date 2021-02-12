// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VMRDeinterlaceTech
    {
        DeinterlaceTech_Unknown = 0,
        DeinterlaceTech_BOBLineReplicate = 0x1,
        DeinterlaceTech_BOBVerticalStretch = 0x2,
        DeinterlaceTech_MedianFiltering = 0x4,
        DeinterlaceTech_EdgeFiltering = 0x10,
        DeinterlaceTech_FieldAdaptive = 0x20,
        DeinterlaceTech_PixelAdaptive = 0x40,
        DeinterlaceTech_MotionVectorSteered = 0x80,
    }
}
