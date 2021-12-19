// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT
{
    /// <include file='D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT.Output"]/*' />
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// <include file='D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT.ProtectionFlags"]/*' />
    public D3D11_AUTHENTICATED_PROTECTION_FLAGS ProtectionFlags;
}
