// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_BRUSH_PROPERTIES.xml' path='doc/member[@name="D2D1_BRUSH_PROPERTIES"]/*' />
public partial struct D2D1_BRUSH_PROPERTIES
{
    /// <include file='D2D1_BRUSH_PROPERTIES.xml' path='doc/member[@name="D2D1_BRUSH_PROPERTIES.opacity"]/*' />
    public float opacity;

    /// <include file='D2D1_BRUSH_PROPERTIES.xml' path='doc/member[@name="D2D1_BRUSH_PROPERTIES.transform"]/*' />
    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F transform;
}
