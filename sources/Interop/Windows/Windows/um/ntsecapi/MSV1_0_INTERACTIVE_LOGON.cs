// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_INTERACTIVE_LOGON.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_LOGON"]/*' />
public partial struct MSV1_0_INTERACTIVE_LOGON
{
    /// <include file='MSV1_0_INTERACTIVE_LOGON.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_LOGON.MessageType"]/*' />
    public MSV1_0_LOGON_SUBMIT_TYPE MessageType;

    /// <include file='MSV1_0_INTERACTIVE_LOGON.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_LOGON.LogonDomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonDomainName;

    /// <include file='MSV1_0_INTERACTIVE_LOGON.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_LOGON.UserName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserName;

    /// <include file='MSV1_0_INTERACTIVE_LOGON.xml' path='doc/member[@name="MSV1_0_INTERACTIVE_LOGON.Password"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Password;
}
