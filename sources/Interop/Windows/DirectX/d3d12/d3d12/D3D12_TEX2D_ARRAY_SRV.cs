// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEX2D_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEX2D_ARRAY_SRV"]/*' />
public partial struct D3D12_TEX2D_ARRAY_SRV
{
    /// <include file='D3D12_TEX2D_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEX2D_ARRAY_SRV.MostDetailedMip"]/*' />
    public uint MostDetailedMip;

    /// <include file='D3D12_TEX2D_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEX2D_ARRAY_SRV.MipLevels"]/*' />
    public uint MipLevels;

    /// <include file='D3D12_TEX2D_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEX2D_ARRAY_SRV.FirstArraySlice"]/*' />
    public uint FirstArraySlice;

    /// <include file='D3D12_TEX2D_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEX2D_ARRAY_SRV.ArraySize"]/*' />
    public uint ArraySize;

    /// <include file='D3D12_TEX2D_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEX2D_ARRAY_SRV.PlaneSlice"]/*' />
    public uint PlaneSlice;

    /// <include file='D3D12_TEX2D_ARRAY_SRV.xml' path='doc/member[@name="D3D12_TEX2D_ARRAY_SRV.ResourceMinLODClamp"]/*' />
    public float ResourceMinLODClamp;
}
