// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='TRANSACTION_NOTIFICATION_TM_ONLINE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_TM_ONLINE_ARGUMENT"]/*' />
public partial struct TRANSACTION_NOTIFICATION_TM_ONLINE_ARGUMENT
{
    /// <include file='TRANSACTION_NOTIFICATION_TM_ONLINE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_TM_ONLINE_ARGUMENT.TmIdentity"]/*' />
    public Guid TmIdentity;

    /// <include file='TRANSACTION_NOTIFICATION_TM_ONLINE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_TM_ONLINE_ARGUMENT.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;
}
