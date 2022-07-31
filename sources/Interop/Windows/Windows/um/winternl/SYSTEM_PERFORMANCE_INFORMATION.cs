// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PERFORMANCE_INFORMATION"]/*' />
public unsafe partial struct SYSTEM_PERFORMANCE_INFORMATION
{
    /// <include file='SYSTEM_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PERFORMANCE_INFORMATION.Reserved1"]/*' />
    [NativeTypeName("BYTE[312]")]
    public fixed byte Reserved1[312];
}
