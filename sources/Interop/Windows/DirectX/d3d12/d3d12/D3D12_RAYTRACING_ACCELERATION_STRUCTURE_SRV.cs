// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV"]/*' />
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV
{
    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV.Location"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong Location;
}
