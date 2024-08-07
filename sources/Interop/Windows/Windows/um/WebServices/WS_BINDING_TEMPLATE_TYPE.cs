// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE"]/*' />
public enum WS_BINDING_TEMPLATE_TYPE
{
    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_BINDING_TEMPLATE_TYPE = 0,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_SSL_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_SSL_BINDING_TEMPLATE_TYPE = 1,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_HEADER_AUTH_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_HEADER_AUTH_BINDING_TEMPLATE_TYPE = 2,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_SSL_HEADER_AUTH_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_SSL_HEADER_AUTH_BINDING_TEMPLATE_TYPE = 3,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_SSL_USERNAME_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_SSL_USERNAME_BINDING_TEMPLATE_TYPE = 4,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_SSL_KERBEROS_APREQ_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_SSL_KERBEROS_APREQ_BINDING_TEMPLATE_TYPE = 5,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_TCP_BINDING_TEMPLATE_TYPE"]/*' />
    WS_TCP_BINDING_TEMPLATE_TYPE = 6,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_TCP_SSPI_BINDING_TEMPLATE_TYPE"]/*' />
    WS_TCP_SSPI_BINDING_TEMPLATE_TYPE = 7,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_TCP_SSPI_USERNAME_BINDING_TEMPLATE_TYPE"]/*' />
    WS_TCP_SSPI_USERNAME_BINDING_TEMPLATE_TYPE = 8,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_TCP_SSPI_KERBEROS_APREQ_BINDING_TEMPLATE_TYPE"]/*' />
    WS_TCP_SSPI_KERBEROS_APREQ_BINDING_TEMPLATE_TYPE = 9,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 10,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_HTTP_SSL_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE"]/*' />
    WS_HTTP_SSL_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 11,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_TCP_SSPI_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE"]/*' />
    WS_TCP_SSPI_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 12,

    /// <include file='WS_BINDING_TEMPLATE_TYPE.xml' path='doc/member[@name="WS_BINDING_TEMPLATE_TYPE.WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE"]/*' />
    WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE_TYPE = 13,
}
