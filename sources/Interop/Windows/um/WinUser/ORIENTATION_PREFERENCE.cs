// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum ORIENTATION_PREFERENCE
    {
        ORIENTATION_PREFERENCE_NONE = 0x0,
        ORIENTATION_PREFERENCE_LANDSCAPE = 0x1,
        ORIENTATION_PREFERENCE_PORTRAIT = 0x2,
        ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED = 0x4,
        ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED = 0x8,
    }
}
