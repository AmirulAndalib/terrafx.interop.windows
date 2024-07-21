// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1"]/*' />
public partial struct D2D1_DRAWING_STATE_DESCRIPTION1
{
    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1.antialiasMode"]/*' />
    public D2D1_ANTIALIAS_MODE antialiasMode;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1.textAntialiasMode"]/*' />
    public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1.tag1"]/*' />
    [NativeTypeName("D2D1_TAG")]
    public ulong tag1;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1.tag2"]/*' />
    [NativeTypeName("D2D1_TAG")]
    public ulong tag2;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1.transform"]/*' />
    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F transform;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1.primitiveBlend"]/*' />
    public D2D1_PRIMITIVE_BLEND primitiveBlend;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION1.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1.unitMode"]/*' />
    public D2D1_UNIT_MODE unitMode;
}
