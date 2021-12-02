// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='KERB_PURGE_TKT_CACHE_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_REQUEST"]/*' />
public partial struct KERB_PURGE_TKT_CACHE_REQUEST
{
    /// <include file='KERB_PURGE_TKT_CACHE_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_REQUEST.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_PURGE_TKT_CACHE_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_REQUEST.LogonId"]/*' />
    public LUID LogonId;

    /// <include file='KERB_PURGE_TKT_CACHE_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_REQUEST.ServerName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerName;

    /// <include file='KERB_PURGE_TKT_CACHE_REQUEST.xml' path='doc/member[@name="KERB_PURGE_TKT_CACHE_REQUEST.RealmName"]/*' />
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING RealmName;
}
