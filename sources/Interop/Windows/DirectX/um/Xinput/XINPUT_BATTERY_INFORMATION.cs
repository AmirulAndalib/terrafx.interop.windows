// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='XINPUT_BATTERY_INFORMATION.xml' path='doc/member[@name="XINPUT_BATTERY_INFORMATION"]/*' />
public partial struct XINPUT_BATTERY_INFORMATION
{
    /// <include file='XINPUT_BATTERY_INFORMATION.xml' path='doc/member[@name="XINPUT_BATTERY_INFORMATION.BatteryType"]/*' />
    public byte BatteryType;

    /// <include file='XINPUT_BATTERY_INFORMATION.xml' path='doc/member[@name="XINPUT_BATTERY_INFORMATION.BatteryLevel"]/*' />
    public byte BatteryLevel;
}
