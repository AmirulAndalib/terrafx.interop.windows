// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_TEXCUBE_ARRAY_SRV1.xml' path='doc/member[@name="D3D10_TEXCUBE_ARRAY_SRV1"]/*' />
public partial struct D3D10_TEXCUBE_ARRAY_SRV1
{
    /// <include file='D3D10_TEXCUBE_ARRAY_SRV1.xml' path='doc/member[@name="D3D10_TEXCUBE_ARRAY_SRV1.MostDetailedMip"]/*' />
    public uint MostDetailedMip;

    /// <include file='D3D10_TEXCUBE_ARRAY_SRV1.xml' path='doc/member[@name="D3D10_TEXCUBE_ARRAY_SRV1.MipLevels"]/*' />
    public uint MipLevels;

    /// <include file='D3D10_TEXCUBE_ARRAY_SRV1.xml' path='doc/member[@name="D3D10_TEXCUBE_ARRAY_SRV1.First2DArrayFace"]/*' />
    public uint First2DArrayFace;

    /// <include file='D3D10_TEXCUBE_ARRAY_SRV1.xml' path='doc/member[@name="D3D10_TEXCUBE_ARRAY_SRV1.NumCubes"]/*' />
    public uint NumCubes;
}
