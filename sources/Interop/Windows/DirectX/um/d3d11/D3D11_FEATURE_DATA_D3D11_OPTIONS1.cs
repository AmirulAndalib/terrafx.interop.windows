// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS1.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS1"]/*' />
[SupportedOSPlatform("windows8.1")]
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS1
{
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS1.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS1.TiledResourcesTier"]/*' />
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;

    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS1.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS1.MinMaxFiltering"]/*' />
    public BOOL MinMaxFiltering;

    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS1.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS1.ClearViewAlsoSupportsDepthOnlyFormats"]/*' />
    public BOOL ClearViewAlsoSupportsDepthOnlyFormats;

    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS1.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS1.MapOnDefaultBuffers"]/*' />
    public BOOL MapOnDefaultBuffers;
}
