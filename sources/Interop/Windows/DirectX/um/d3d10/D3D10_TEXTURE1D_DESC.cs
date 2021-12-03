// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC"]/*' />
public partial struct D3D10_TEXTURE1D_DESC
{
    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.Width"]/*' />
    public uint Width;

    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.MipLevels"]/*' />
    public uint MipLevels;

    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.ArraySize"]/*' />
    public uint ArraySize;

    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.Usage"]/*' />
    public D3D10_USAGE Usage;

    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.BindFlags"]/*' />
    public uint BindFlags;

    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.CPUAccessFlags"]/*' />
    public uint CPUAccessFlags;

    /// <include file='D3D10_TEXTURE1D_DESC.xml' path='doc/member[@name="D3D10_TEXTURE1D_DESC.MiscFlags"]/*' />
    public uint MiscFlags;
}
