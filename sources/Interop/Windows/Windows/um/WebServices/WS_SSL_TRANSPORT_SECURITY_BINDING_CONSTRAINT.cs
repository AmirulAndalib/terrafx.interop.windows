// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT"]/*' />
public partial struct WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT
{
    /// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT.bindingConstraint"]/*' />
    public WS_SECURITY_BINDING_CONSTRAINT bindingConstraint;

    /// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING_CONSTRAINT.@out"]/*' />
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/WebServices.h:6172:5)")]
    public _out_e__Struct @out;

    /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct"]/*' />
    public partial struct _out_e__Struct
    {
        /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct.clientCertCredentialRequired"]/*' />
        public BOOL clientCertCredentialRequired;
    }
}
