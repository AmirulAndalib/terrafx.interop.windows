// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='WS_ENDPOINT_POLICY_EXTENSION.xml' path='doc/member[@name="WS_ENDPOINT_POLICY_EXTENSION"]/*' />
public unsafe partial struct WS_ENDPOINT_POLICY_EXTENSION
{
    /// <include file='WS_ENDPOINT_POLICY_EXTENSION.xml' path='doc/member[@name="WS_ENDPOINT_POLICY_EXTENSION.policyExtension"]/*' />
    public WS_POLICY_EXTENSION policyExtension;

    /// <include file='WS_ENDPOINT_POLICY_EXTENSION.xml' path='doc/member[@name="WS_ENDPOINT_POLICY_EXTENSION.assertionName"]/*' />
    public WS_XML_STRING* assertionName;

    /// <include file='WS_ENDPOINT_POLICY_EXTENSION.xml' path='doc/member[@name="WS_ENDPOINT_POLICY_EXTENSION.assertionNs"]/*' />
    public WS_XML_STRING* assertionNs;

    /// <include file='WS_ENDPOINT_POLICY_EXTENSION.xml' path='doc/member[@name="WS_ENDPOINT_POLICY_EXTENSION.@out"]/*' />
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/WebServices.h:6349:5)")]
    public _out_e__Struct @out;

    /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct"]/*' />
    public partial struct _out_e__Struct
    {
        /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct.assertionValue"]/*' />
        public IntPtr assertionValue;
    }
}
