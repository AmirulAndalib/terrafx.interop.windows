// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TXFS_ROLLFORWARD_REDO_INFORMATION
    {
        public LARGE_INTEGER LastVirtualClock;

        [NativeTypeName("DWORDLONG")]
        public ulong LastRedoLsn;

        [NativeTypeName("DWORDLONG")]
        public ulong HighestRecoveryLsn;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
