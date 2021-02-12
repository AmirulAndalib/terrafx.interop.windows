// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct REFS_SMR_VOLUME_INFO_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public LARGE_INTEGER SizeOfRandomlyWritableTier;

        public LARGE_INTEGER FreeSpaceInRandomlyWritableTier;

        public LARGE_INTEGER SizeofSMRTier;

        public LARGE_INTEGER FreeSpaceInSMRTier;

        public LARGE_INTEGER UsableFreeSpaceInSMRTier;

        public REFS_SMR_VOLUME_GC_STATE VolumeGcState;

        [NativeTypeName("DWORD")]
        public uint VolumeGcLastStatus;

        [NativeTypeName("DWORDLONG [7]")]
        public fixed ulong Unused[7];
    }
}
