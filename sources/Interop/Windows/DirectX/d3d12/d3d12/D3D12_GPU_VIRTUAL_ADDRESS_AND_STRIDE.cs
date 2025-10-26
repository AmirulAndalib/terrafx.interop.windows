// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE"]/*' />
public partial struct D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE
{
    /// <include file='D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.StartAddress"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong StartAddress;

    /// <include file='D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE.StrideInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong StrideInBytes;
}
