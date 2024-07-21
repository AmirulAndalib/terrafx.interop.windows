// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_MAPPED_TEXTURE3D.xml' path='doc/member[@name="D3D10_MAPPED_TEXTURE3D"]/*' />
public unsafe partial struct D3D10_MAPPED_TEXTURE3D
{
    /// <include file='D3D10_MAPPED_TEXTURE3D.xml' path='doc/member[@name="D3D10_MAPPED_TEXTURE3D.pData"]/*' />
    public void* pData;

    /// <include file='D3D10_MAPPED_TEXTURE3D.xml' path='doc/member[@name="D3D10_MAPPED_TEXTURE3D.RowPitch"]/*' />
    public uint RowPitch;

    /// <include file='D3D10_MAPPED_TEXTURE3D.xml' path='doc/member[@name="D3D10_MAPPED_TEXTURE3D.DepthPitch"]/*' />
    public uint DepthPitch;
}
