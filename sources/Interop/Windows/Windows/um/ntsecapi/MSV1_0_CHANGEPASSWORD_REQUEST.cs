// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_CHANGEPASSWORD_REQUEST.xml' path='doc/member[@name="MSV1_0_CHANGEPASSWORD_REQUEST"]/*' />
public partial struct MSV1_0_CHANGEPASSWORD_REQUEST
{
    /// <include file='MSV1_0_CHANGEPASSWORD_REQUEST.xml' path='doc/member[@name="MSV1_0_CHANGEPASSWORD_REQUEST.MessageType"]/*' />
    public MSV1_0_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='MSV1_0_CHANGEPASSWORD_REQUEST.xml' path='doc/member[@name="MSV1_0_CHANGEPASSWORD_REQUEST.DomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;

    /// <include file='MSV1_0_CHANGEPASSWORD_REQUEST.xml' path='doc/member[@name="MSV1_0_CHANGEPASSWORD_REQUEST.AccountName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING AccountName;

    /// <include file='MSV1_0_CHANGEPASSWORD_REQUEST.xml' path='doc/member[@name="MSV1_0_CHANGEPASSWORD_REQUEST.OldPassword"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING OldPassword;

    /// <include file='MSV1_0_CHANGEPASSWORD_REQUEST.xml' path='doc/member[@name="MSV1_0_CHANGEPASSWORD_REQUEST.NewPassword"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING NewPassword;

    /// <include file='MSV1_0_CHANGEPASSWORD_REQUEST.xml' path='doc/member[@name="MSV1_0_CHANGEPASSWORD_REQUEST.Impersonating"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Impersonating;
}
