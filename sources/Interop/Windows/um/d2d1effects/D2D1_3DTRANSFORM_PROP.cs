// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_3DTRANSFORM_PROP : uint
    {
        D2D1_3DTRANSFORM_PROP_INTERPOLATION_MODE = 0,
        D2D1_3DTRANSFORM_PROP_BORDER_MODE = 1,
        D2D1_3DTRANSFORM_PROP_TRANSFORM_MATRIX = 2,
        D2D1_3DTRANSFORM_PROP_FORCE_DWORD = 0xffffffff,
    }
}
