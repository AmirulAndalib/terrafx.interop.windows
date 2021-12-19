// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_SHARPEN_PROP.xml' path='doc/member[@name="D2D1_SHARPEN_PROP"]/*' />
public enum D2D1_SHARPEN_PROP : uint
{
    /// <include file='D2D1_SHARPEN_PROP.xml' path='doc/member[@name="D2D1_SHARPEN_PROP.D2D1_SHARPEN_PROP_SHARPNESS"]/*' />
    D2D1_SHARPEN_PROP_SHARPNESS = 0,

    /// <include file='D2D1_SHARPEN_PROP.xml' path='doc/member[@name="D2D1_SHARPEN_PROP.D2D1_SHARPEN_PROP_THRESHOLD"]/*' />
    D2D1_SHARPEN_PROP_THRESHOLD = 1,

    /// <include file='D2D1_SHARPEN_PROP.xml' path='doc/member[@name="D2D1_SHARPEN_PROP.D2D1_SHARPEN_PROP_FORCE_DWORD"]/*' />
    D2D1_SHARPEN_PROP_FORCE_DWORD = 0xffffffff,
}
