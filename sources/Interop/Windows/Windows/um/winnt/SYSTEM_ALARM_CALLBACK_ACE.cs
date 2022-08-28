// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_ALARM_CALLBACK_ACE.xml' path='doc/member[@name="SYSTEM_ALARM_CALLBACK_ACE"]/*' />
public partial struct SYSTEM_ALARM_CALLBACK_ACE
{
    /// <include file='SYSTEM_ALARM_CALLBACK_ACE.xml' path='doc/member[@name="SYSTEM_ALARM_CALLBACK_ACE.Header"]/*' />
    public ACE_HEADER Header;

    /// <include file='SYSTEM_ALARM_CALLBACK_ACE.xml' path='doc/member[@name="SYSTEM_ALARM_CALLBACK_ACE.Mask"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint Mask;

    /// <include file='SYSTEM_ALARM_CALLBACK_ACE.xml' path='doc/member[@name="SYSTEM_ALARM_CALLBACK_ACE.SidStart"]/*' />
    [NativeTypeName("DWORD")]
    public uint SidStart;
}
