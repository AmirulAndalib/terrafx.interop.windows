// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='POLICY_AUDIT_SID_ARRAY.xml' path='doc/member[@name="POLICY_AUDIT_SID_ARRAY"]/*' />
public unsafe partial struct POLICY_AUDIT_SID_ARRAY
{
    /// <include file='POLICY_AUDIT_SID_ARRAY.xml' path='doc/member[@name="POLICY_AUDIT_SID_ARRAY.UsersCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint UsersCount;

    /// <include file='POLICY_AUDIT_SID_ARRAY.xml' path='doc/member[@name="POLICY_AUDIT_SID_ARRAY.UserSidArray"]/*' />
    [NativeTypeName("PSID *")]
    public void** UserSidArray;
}
