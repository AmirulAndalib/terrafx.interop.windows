// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP"]/*' />
public enum D2D1_POINTDIFFUSE_PROP : uint
{
    /// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP.D2D1_POINTDIFFUSE_PROP_LIGHT_POSITION"]/*' />
    D2D1_POINTDIFFUSE_PROP_LIGHT_POSITION = 0,

    /// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP.D2D1_POINTDIFFUSE_PROP_DIFFUSE_CONSTANT"]/*' />
    D2D1_POINTDIFFUSE_PROP_DIFFUSE_CONSTANT = 1,

    /// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP.D2D1_POINTDIFFUSE_PROP_SURFACE_SCALE"]/*' />
    D2D1_POINTDIFFUSE_PROP_SURFACE_SCALE = 2,

    /// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP.D2D1_POINTDIFFUSE_PROP_COLOR"]/*' />
    D2D1_POINTDIFFUSE_PROP_COLOR = 3,

    /// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP.D2D1_POINTDIFFUSE_PROP_KERNEL_UNIT_LENGTH"]/*' />
    D2D1_POINTDIFFUSE_PROP_KERNEL_UNIT_LENGTH = 4,

    /// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP.D2D1_POINTDIFFUSE_PROP_SCALE_MODE"]/*' />
    D2D1_POINTDIFFUSE_PROP_SCALE_MODE = 5,

    /// <include file='D2D1_POINTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_POINTDIFFUSE_PROP.D2D1_POINTDIFFUSE_PROP_FORCE_DWORD"]/*' />
    D2D1_POINTDIFFUSE_PROP_FORCE_DWORD = 0xffffffff,
}
