// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_TEMPERATURE_THRESHOLD
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("WORD")]
        public ushort Flags;

        [NativeTypeName("WORD")]
        public ushort Index;

        [NativeTypeName("SHORT")]
        public short Threshold;

        [NativeTypeName("BOOLEAN")]
        public byte OverThreshold;

        [NativeTypeName("BYTE")]
        public byte Reserved;
    }
}
