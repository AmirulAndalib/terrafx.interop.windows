// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_SVG_ATTRIBUTE_STRING_TYPE : uint
    {
        D2D1_SVG_ATTRIBUTE_STRING_TYPE_SVG = 0,
        D2D1_SVG_ATTRIBUTE_STRING_TYPE_ID = 1,
        D2D1_SVG_ATTRIBUTE_STRING_TYPE_FORCE_DWORD = 0xffffffff,
    }
}
