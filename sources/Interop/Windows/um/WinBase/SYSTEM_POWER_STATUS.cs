// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SYSTEM_POWER_STATUS
    {
        [NativeTypeName("BYTE")]
        public byte ACLineStatus;

        [NativeTypeName("BYTE")]
        public byte BatteryFlag;

        [NativeTypeName("BYTE")]
        public byte BatteryLifePercent;

        [NativeTypeName("BYTE")]
        public byte SystemStatusFlag;

        [NativeTypeName("DWORD")]
        public uint BatteryLifeTime;

        [NativeTypeName("DWORD")]
        public uint BatteryFullLifeTime;
    }
}
