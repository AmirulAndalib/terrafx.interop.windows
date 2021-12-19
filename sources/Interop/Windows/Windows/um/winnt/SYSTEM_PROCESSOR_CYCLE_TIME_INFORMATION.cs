// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION"]/*' />
public partial struct SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION
{
    /// <include file='SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION.CycleTime"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong CycleTime;
}
