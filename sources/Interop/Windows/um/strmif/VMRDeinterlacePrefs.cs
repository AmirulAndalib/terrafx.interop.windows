// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VMRDeinterlacePrefs
    {
        DeinterlacePref_NextBest = 0x1,
        DeinterlacePref_BOB = 0x2,
        DeinterlacePref_Weave = 0x4,
        DeinterlacePref_Mask = 0x7,
    }
}
