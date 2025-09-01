// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_GPU_VIRTUAL_ADDRESS_RANGE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_RANGE"]/*' />
public partial struct D3D12_GPU_VIRTUAL_ADDRESS_RANGE
{
    /// <include file='D3D12_GPU_VIRTUAL_ADDRESS_RANGE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_RANGE.StartAddress"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong StartAddress;

    /// <include file='D3D12_GPU_VIRTUAL_ADDRESS_RANGE.xml' path='doc/member[@name="D3D12_GPU_VIRTUAL_ADDRESS_RANGE.SizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SizeInBytes;
}
