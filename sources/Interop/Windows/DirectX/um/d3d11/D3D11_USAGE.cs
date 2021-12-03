// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_USAGE.xml' path='doc/member[@name="D3D11_USAGE"]/*' />
public enum D3D11_USAGE
{
    /// <include file='D3D11_USAGE.xml' path='doc/member[@name="D3D11_USAGE.D3D11_USAGE_DEFAULT"]/*' />
    D3D11_USAGE_DEFAULT = 0,

    /// <include file='D3D11_USAGE.xml' path='doc/member[@name="D3D11_USAGE.D3D11_USAGE_IMMUTABLE"]/*' />
    D3D11_USAGE_IMMUTABLE = 1,

    /// <include file='D3D11_USAGE.xml' path='doc/member[@name="D3D11_USAGE.D3D11_USAGE_DYNAMIC"]/*' />
    D3D11_USAGE_DYNAMIC = 2,

    /// <include file='D3D11_USAGE.xml' path='doc/member[@name="D3D11_USAGE.D3D11_USAGE_STAGING"]/*' />
    D3D11_USAGE_STAGING = 3,
}
