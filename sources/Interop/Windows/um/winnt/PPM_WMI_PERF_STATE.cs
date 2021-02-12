// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PPM_WMI_PERF_STATE
    {
        [NativeTypeName("DWORD")]
        public uint Frequency;

        [NativeTypeName("DWORD")]
        public uint Power;

        [NativeTypeName("BYTE")]
        public byte PercentFrequency;

        [NativeTypeName("BYTE")]
        public byte IncreaseLevel;

        [NativeTypeName("BYTE")]
        public byte DecreaseLevel;

        [NativeTypeName("BYTE")]
        public byte Type;

        [NativeTypeName("DWORD")]
        public uint IncreaseTime;

        [NativeTypeName("DWORD")]
        public uint DecreaseTime;

        [NativeTypeName("DWORD64")]
        public ulong Control;

        [NativeTypeName("DWORD64")]
        public ulong Status;

        [NativeTypeName("DWORD")]
        public uint HitCount;

        [NativeTypeName("DWORD")]
        public uint Reserved1;

        [NativeTypeName("DWORD64")]
        public ulong Reserved2;

        [NativeTypeName("DWORD64")]
        public ulong Reserved3;
    }
}
