// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D11_MESSAGE_SEVERITY"]/*' />
public enum D3D11_MESSAGE_SEVERITY
{
    /// <include file='D3D11_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D11_MESSAGE_SEVERITY.D3D11_MESSAGE_SEVERITY_CORRUPTION"]/*' />
    D3D11_MESSAGE_SEVERITY_CORRUPTION = 0,

    /// <include file='D3D11_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D11_MESSAGE_SEVERITY.D3D11_MESSAGE_SEVERITY_ERROR"]/*' />
    D3D11_MESSAGE_SEVERITY_ERROR = (D3D11_MESSAGE_SEVERITY_CORRUPTION + 1),

    /// <include file='D3D11_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D11_MESSAGE_SEVERITY.D3D11_MESSAGE_SEVERITY_WARNING"]/*' />
    D3D11_MESSAGE_SEVERITY_WARNING = (D3D11_MESSAGE_SEVERITY_ERROR + 1),

    /// <include file='D3D11_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D11_MESSAGE_SEVERITY.D3D11_MESSAGE_SEVERITY_INFO"]/*' />
    D3D11_MESSAGE_SEVERITY_INFO = (D3D11_MESSAGE_SEVERITY_WARNING + 1),

    /// <include file='D3D11_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D11_MESSAGE_SEVERITY.D3D11_MESSAGE_SEVERITY_MESSAGE"]/*' />
    D3D11_MESSAGE_SEVERITY_MESSAGE = (D3D11_MESSAGE_SEVERITY_INFO + 1),
}
