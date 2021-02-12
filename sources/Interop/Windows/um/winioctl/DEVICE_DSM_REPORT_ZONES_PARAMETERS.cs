// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DEVICE_DSM_REPORT_ZONES_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("BYTE")]
        public byte ReportOption;

        [NativeTypeName("BYTE")]
        public byte Partial;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved[2];
    }
}
