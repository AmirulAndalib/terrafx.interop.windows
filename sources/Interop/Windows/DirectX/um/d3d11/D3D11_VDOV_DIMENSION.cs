// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VDOV_DIMENSION.xml' path='doc/member[@name="D3D11_VDOV_DIMENSION"]/*' />
[SupportedOSPlatform("windows8.0")]
public enum D3D11_VDOV_DIMENSION
{
    /// <include file='D3D11_VDOV_DIMENSION.xml' path='doc/member[@name="D3D11_VDOV_DIMENSION.D3D11_VDOV_DIMENSION_UNKNOWN"]/*' />
    D3D11_VDOV_DIMENSION_UNKNOWN = 0,

    /// <include file='D3D11_VDOV_DIMENSION.xml' path='doc/member[@name="D3D11_VDOV_DIMENSION.D3D11_VDOV_DIMENSION_TEXTURE2D"]/*' />
    D3D11_VDOV_DIMENSION_TEXTURE2D = 1,
}
