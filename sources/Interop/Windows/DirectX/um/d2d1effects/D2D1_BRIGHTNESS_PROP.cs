// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_BRIGHTNESS_PROP.xml' path='doc/member[@name="D2D1_BRIGHTNESS_PROP"]/*' />
public enum D2D1_BRIGHTNESS_PROP : uint
{
    /// <include file='D2D1_BRIGHTNESS_PROP.xml' path='doc/member[@name="D2D1_BRIGHTNESS_PROP.D2D1_BRIGHTNESS_PROP_WHITE_POINT"]/*' />
    D2D1_BRIGHTNESS_PROP_WHITE_POINT = 0,

    /// <include file='D2D1_BRIGHTNESS_PROP.xml' path='doc/member[@name="D2D1_BRIGHTNESS_PROP.D2D1_BRIGHTNESS_PROP_BLACK_POINT"]/*' />
    D2D1_BRIGHTNESS_PROP_BLACK_POINT = 1,

    /// <include file='D2D1_BRIGHTNESS_PROP.xml' path='doc/member[@name="D2D1_BRIGHTNESS_PROP.D2D1_BRIGHTNESS_PROP_FORCE_DWORD"]/*' />
    D2D1_BRIGHTNESS_PROP_FORCE_DWORD = 0xffffffff,
}
