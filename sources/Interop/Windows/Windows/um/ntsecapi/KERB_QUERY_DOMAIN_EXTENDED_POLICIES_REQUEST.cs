// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST"]/*' />
public partial struct KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST
{
    /// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_REQUEST.DomainName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
}
