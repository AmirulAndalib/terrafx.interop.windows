// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO"]/*' />
public partial struct KERB_TICKET_CACHE_INFO
{
    /// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO.ServerName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerName;

    /// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO.RealmName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING RealmName;

    /// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO.StartTime"]/*' />
    public LARGE_INTEGER StartTime;

    /// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO.EndTime"]/*' />
    public LARGE_INTEGER EndTime;

    /// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO.RenewTime"]/*' />
    public LARGE_INTEGER RenewTime;

    /// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO.EncryptionType"]/*' />
    [NativeTypeName("LONG")]
    public int EncryptionType;

    /// <include file='KERB_TICKET_CACHE_INFO.xml' path='doc/member[@name="KERB_TICKET_CACHE_INFO.TicketFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint TicketFlags;
}
