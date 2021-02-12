// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_COLORMANAGEMENT_PROP : uint
    {
        D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT = 0,
        D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT = 1,
        D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT = 2,
        D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT = 3,
        D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE = 4,
        D2D1_COLORMANAGEMENT_PROP_QUALITY = 5,
        D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD = 0xffffffff,
    }
}
