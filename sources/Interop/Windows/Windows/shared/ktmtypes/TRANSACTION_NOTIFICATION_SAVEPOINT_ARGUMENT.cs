// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TRANSACTION_NOTIFICATION_SAVEPOINT_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_SAVEPOINT_ARGUMENT"]/*' />
public partial struct TRANSACTION_NOTIFICATION_SAVEPOINT_ARGUMENT
{
    /// <include file='TRANSACTION_NOTIFICATION_SAVEPOINT_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_SAVEPOINT_ARGUMENT.SavepointId"]/*' />
    [NativeTypeName("SAVEPOINT_ID")]
    public uint SavepointId;
}
