// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TEX2D_UAV1.xml' path='doc/member[@name="D3D11_TEX2D_UAV1"]/*' />
public partial struct D3D11_TEX2D_UAV1
{
    /// <include file='D3D11_TEX2D_UAV1.xml' path='doc/member[@name="D3D11_TEX2D_UAV1.MipSlice"]/*' />
    public uint MipSlice;

    /// <include file='D3D11_TEX2D_UAV1.xml' path='doc/member[@name="D3D11_TEX2D_UAV1.PlaneSlice"]/*' />
    public uint PlaneSlice;
}
