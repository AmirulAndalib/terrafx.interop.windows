// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT
{
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT.Parameters"]/*' />
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;

    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT.Protections"]/*' />
    public D3D11_AUTHENTICATED_PROTECTION_FLAGS Protections;
}
