// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SAMPLE_POSITION.xml' path='doc/member[@name="D3D12_SAMPLE_POSITION"]/*' />
public partial struct D3D12_SAMPLE_POSITION
{
    /// <include file='D3D12_SAMPLE_POSITION.xml' path='doc/member[@name="D3D12_SAMPLE_POSITION.X"]/*' />
    [NativeTypeName("INT8")]
    public sbyte X;

    /// <include file='D3D12_SAMPLE_POSITION.xml' path='doc/member[@name="D3D12_SAMPLE_POSITION.Y"]/*' />
    [NativeTypeName("INT8")]
    public sbyte Y;
}
