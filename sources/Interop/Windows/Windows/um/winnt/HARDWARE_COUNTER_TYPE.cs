// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HARDWARE_COUNTER_TYPE.xml' path='doc/member[@name="HARDWARE_COUNTER_TYPE"]/*' />
public enum HARDWARE_COUNTER_TYPE
{
    /// <include file='HARDWARE_COUNTER_TYPE.xml' path='doc/member[@name="HARDWARE_COUNTER_TYPE.PMCCounter"]/*' />
    PMCCounter,

    /// <include file='HARDWARE_COUNTER_TYPE.xml' path='doc/member[@name="HARDWARE_COUNTER_TYPE.MaxHardwareCounterType"]/*' />
    MaxHardwareCounterType,
}
