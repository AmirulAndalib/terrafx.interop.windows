// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_INPUT_LAYOUT_DESC.xml' path='doc/member[@name="D3D12_INPUT_LAYOUT_DESC"]/*' />
public unsafe partial struct D3D12_INPUT_LAYOUT_DESC
{
    /// <include file='D3D12_INPUT_LAYOUT_DESC.xml' path='doc/member[@name="D3D12_INPUT_LAYOUT_DESC.pInputElementDescs"]/*' />
    [NativeTypeName("const D3D12_INPUT_ELEMENT_DESC *")]
    public D3D12_INPUT_ELEMENT_DESC* pInputElementDescs;

    /// <include file='D3D12_INPUT_LAYOUT_DESC.xml' path='doc/member[@name="D3D12_INPUT_LAYOUT_DESC.NumElements"]/*' />
    public uint NumElements;
}
