// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MIB_IPMCAST_OIF_STATS_LH
    {
        [NativeTypeName("DWORD")]
        public uint dwOutIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwNextHopAddr;

        [NativeTypeName("DWORD")]
        public uint dwDialContext;

        [NativeTypeName("ULONG")]
        public uint ulTtlTooLow;

        [NativeTypeName("ULONG")]
        public uint ulFragNeeded;

        [NativeTypeName("ULONG")]
        public uint ulOutPackets;

        [NativeTypeName("ULONG")]
        public uint ulOutDiscards;
    }
}