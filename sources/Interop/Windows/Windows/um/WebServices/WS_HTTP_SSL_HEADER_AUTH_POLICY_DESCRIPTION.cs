// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.xml' path='doc/member[@name="WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION"]/*' />
public partial struct WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION
{
    /// <include file='WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.xml' path='doc/member[@name="WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.channelProperties"]/*' />
    public WS_CHANNEL_PROPERTIES channelProperties;

    /// <include file='WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.xml' path='doc/member[@name="WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.securityProperties"]/*' />
    public WS_SECURITY_PROPERTIES securityProperties;

    /// <include file='WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.xml' path='doc/member[@name="WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.sslTransportSecurityBinding"]/*' />
    public WS_SSL_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION sslTransportSecurityBinding;

    /// <include file='WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.xml' path='doc/member[@name="WS_HTTP_SSL_HEADER_AUTH_POLICY_DESCRIPTION.httpHeaderAuthSecurityBinding"]/*' />
    public WS_HTTP_HEADER_AUTH_SECURITY_BINDING_POLICY_DESCRIPTION httpHeaderAuthSecurityBinding;
}
