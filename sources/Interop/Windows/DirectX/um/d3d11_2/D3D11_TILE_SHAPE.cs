// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TILE_SHAPE.xml' path='doc/member[@name="D3D11_TILE_SHAPE"]/*' />
[SupportedOSPlatform("windows8.1")]
public partial struct D3D11_TILE_SHAPE
{
    /// <include file='D3D11_TILE_SHAPE.xml' path='doc/member[@name="D3D11_TILE_SHAPE.WidthInTexels"]/*' />
    public uint WidthInTexels;

    /// <include file='D3D11_TILE_SHAPE.xml' path='doc/member[@name="D3D11_TILE_SHAPE.HeightInTexels"]/*' />
    public uint HeightInTexels;

    /// <include file='D3D11_TILE_SHAPE.xml' path='doc/member[@name="D3D11_TILE_SHAPE.DepthInTexels"]/*' />
    public uint DepthInTexels;
}
