// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_ORIENTATION : uint
    {
        D2D1_ORIENTATION_DEFAULT = 1,
        D2D1_ORIENTATION_FLIP_HORIZONTAL = 2,
        D2D1_ORIENTATION_ROTATE_CLOCKWISE180 = 3,
        D2D1_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL = 4,
        D2D1_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL = 5,
        D2D1_ORIENTATION_ROTATE_CLOCKWISE270 = 6,
        D2D1_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL = 7,
        D2D1_ORIENTATION_ROTATE_CLOCKWISE90 = 8,
        D2D1_ORIENTATION_FORCE_DWORD = 0xffffffff,
    }
}
