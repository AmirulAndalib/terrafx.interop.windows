// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TEX3D_UAV.xml' path='doc/member[@name="D3D11_TEX3D_UAV"]/*' />
public partial struct D3D11_TEX3D_UAV
{
    /// <include file='D3D11_TEX3D_UAV.xml' path='doc/member[@name="D3D11_TEX3D_UAV.MipSlice"]/*' />
    public uint MipSlice;

    /// <include file='D3D11_TEX3D_UAV.xml' path='doc/member[@name="D3D11_TEX3D_UAV.FirstWSlice"]/*' />
    public uint FirstWSlice;

    /// <include file='D3D11_TEX3D_UAV.xml' path='doc/member[@name="D3D11_TEX3D_UAV.WSize"]/*' />
    public uint WSize;
}
