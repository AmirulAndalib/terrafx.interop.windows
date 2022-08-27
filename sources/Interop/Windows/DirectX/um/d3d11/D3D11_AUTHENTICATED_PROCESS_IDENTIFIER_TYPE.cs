// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE
{
    /// <include file='D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE.D3D11_PROCESSIDTYPE_UNKNOWN"]/*' />
    D3D11_PROCESSIDTYPE_UNKNOWN = 0,

    /// <include file='D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE.D3D11_PROCESSIDTYPE_DWM"]/*' />
    D3D11_PROCESSIDTYPE_DWM = 1,

    /// <include file='D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE.D3D11_PROCESSIDTYPE_HANDLE"]/*' />
    D3D11_PROCESSIDTYPE_HANDLE = 2,
}
