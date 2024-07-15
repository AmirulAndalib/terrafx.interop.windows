// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_TEX3D_RTV.xml' path='doc/member[@name="D3D10_TEX3D_RTV"]/*' />
public partial struct D3D10_TEX3D_RTV
{
    /// <include file='D3D10_TEX3D_RTV.xml' path='doc/member[@name="D3D10_TEX3D_RTV.MipSlice"]/*' />
    public uint MipSlice;

    /// <include file='D3D10_TEX3D_RTV.xml' path='doc/member[@name="D3D10_TEX3D_RTV.FirstWSlice"]/*' />
    public uint FirstWSlice;

    /// <include file='D3D10_TEX3D_RTV.xml' path='doc/member[@name="D3D10_TEX3D_RTV.WSize"]/*' />
    public uint WSize;
}
