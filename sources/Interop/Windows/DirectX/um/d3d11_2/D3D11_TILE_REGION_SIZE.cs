// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D11_TILE_REGION_SIZE"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct D3D11_TILE_REGION_SIZE
{
    /// <include file='D3D11_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D11_TILE_REGION_SIZE.NumTiles"]/*' />
    public uint NumTiles;

    /// <include file='D3D11_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D11_TILE_REGION_SIZE.bUseBox"]/*' />
    public BOOL bUseBox;

    /// <include file='D3D11_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D11_TILE_REGION_SIZE.Width"]/*' />
    public uint Width;

    /// <include file='D3D11_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D11_TILE_REGION_SIZE.Height"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Height;

    /// <include file='D3D11_TILE_REGION_SIZE.xml' path='doc/member[@name="D3D11_TILE_REGION_SIZE.Depth"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Depth;
}
