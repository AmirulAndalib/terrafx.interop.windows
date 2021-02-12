// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_DISPLACEMENTMAP_PROP : uint
    {
        D2D1_DISPLACEMENTMAP_PROP_SCALE = 0,
        D2D1_DISPLACEMENTMAP_PROP_X_CHANNEL_SELECT = 1,
        D2D1_DISPLACEMENTMAP_PROP_Y_CHANNEL_SELECT = 2,
        D2D1_DISPLACEMENTMAP_PROP_FORCE_DWORD = 0xffffffff,
    }
}
