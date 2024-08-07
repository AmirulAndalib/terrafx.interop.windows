// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC"]/*' />
public partial struct D3D11_BLEND_DESC
{
    /// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC.AlphaToCoverageEnable"]/*' />
    public BOOL AlphaToCoverageEnable;

    /// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC.IndependentBlendEnable"]/*' />
    public BOOL IndependentBlendEnable;

    /// <include file='D3D11_BLEND_DESC.xml' path='doc/member[@name="D3D11_BLEND_DESC.RenderTarget"]/*' />
    [NativeTypeName("D3D11_RENDER_TARGET_BLEND_DESC[8]")]
    public _RenderTarget_e__FixedBuffer RenderTarget;

    /// <include file='_RenderTarget_e__FixedBuffer.xml' path='doc/member[@name="_RenderTarget_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _RenderTarget_e__FixedBuffer
    {
        public D3D11_RENDER_TARGET_BLEND_DESC e0;
    }
}
