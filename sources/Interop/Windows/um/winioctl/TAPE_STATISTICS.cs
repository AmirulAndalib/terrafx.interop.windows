// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TAPE_STATISTICS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public LARGE_INTEGER RecoveredWrites;

        public LARGE_INTEGER UnrecoveredWrites;

        public LARGE_INTEGER RecoveredReads;

        public LARGE_INTEGER UnrecoveredReads;

        [NativeTypeName("BYTE")]
        public byte CompressionRatioReads;

        [NativeTypeName("BYTE")]
        public byte CompressionRatioWrites;
    }
}
