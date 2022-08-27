// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING.xml' path='doc/member[@name="WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING
{
    /// <include file='WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING.xml' path='doc/member[@name="WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING.binding"]/*' />
    public WS_SECURITY_BINDING binding;

    /// <include file='WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING.xml' path='doc/member[@name="WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING.clientCredential"]/*' />
    public WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL* clientCredential;
}
