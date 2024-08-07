// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION"]/*' />
public partial struct D2D1_BLEND_DESCRIPTION
{
    /// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION.sourceBlend"]/*' />
    public D2D1_BLEND sourceBlend;

    /// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION.destinationBlend"]/*' />
    public D2D1_BLEND destinationBlend;

    /// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION.blendOperation"]/*' />
    public D2D1_BLEND_OPERATION blendOperation;

    /// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION.sourceBlendAlpha"]/*' />
    public D2D1_BLEND sourceBlendAlpha;

    /// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION.destinationBlendAlpha"]/*' />
    public D2D1_BLEND destinationBlendAlpha;

    /// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION.blendOperationAlpha"]/*' />
    public D2D1_BLEND_OPERATION blendOperationAlpha;

    /// <include file='D2D1_BLEND_DESCRIPTION.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION.blendFactor"]/*' />
    [NativeTypeName("FLOAT[4]")]
    public _blendFactor_e__FixedBuffer blendFactor;

    /// <include file='_blendFactor_e__FixedBuffer.xml' path='doc/member[@name="_blendFactor_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _blendFactor_e__FixedBuffer
    {
        public float e0;
    }
}
