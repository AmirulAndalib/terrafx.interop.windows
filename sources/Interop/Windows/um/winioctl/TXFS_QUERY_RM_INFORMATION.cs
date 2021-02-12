// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TXFS_QUERY_RM_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint BytesRequired;

        [NativeTypeName("DWORDLONG")]
        public ulong TailLsn;

        [NativeTypeName("DWORDLONG")]
        public ulong CurrentLsn;

        [NativeTypeName("DWORDLONG")]
        public ulong ArchiveTailLsn;

        [NativeTypeName("DWORDLONG")]
        public ulong LogContainerSize;

        public LARGE_INTEGER HighestVirtualClock;

        [NativeTypeName("DWORD")]
        public uint LogContainerCount;

        [NativeTypeName("DWORD")]
        public uint LogContainerCountMax;

        [NativeTypeName("DWORD")]
        public uint LogContainerCountMin;

        [NativeTypeName("DWORD")]
        public uint LogGrowthIncrement;

        [NativeTypeName("DWORD")]
        public uint LogAutoShrinkPercentage;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("WORD")]
        public ushort LoggingMode;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("DWORD")]
        public uint RmState;

        [NativeTypeName("DWORDLONG")]
        public ulong LogCapacity;

        [NativeTypeName("DWORDLONG")]
        public ulong LogFree;

        [NativeTypeName("DWORDLONG")]
        public ulong TopsSize;

        [NativeTypeName("DWORDLONG")]
        public ulong TopsUsed;

        [NativeTypeName("DWORDLONG")]
        public ulong TransactionCount;

        [NativeTypeName("DWORDLONG")]
        public ulong OnePCCount;

        [NativeTypeName("DWORDLONG")]
        public ulong TwoPCCount;

        [NativeTypeName("DWORDLONG")]
        public ulong NumberLogFileFull;

        [NativeTypeName("DWORDLONG")]
        public ulong OldestTransactionAge;

        [NativeTypeName("GUID")]
        public Guid RMName;

        [NativeTypeName("DWORD")]
        public uint TmLogPathOffset;
    }
}
