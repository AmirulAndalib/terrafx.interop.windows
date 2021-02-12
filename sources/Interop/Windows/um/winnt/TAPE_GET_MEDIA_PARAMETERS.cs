// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TAPE_GET_MEDIA_PARAMETERS
    {
        public LARGE_INTEGER Capacity;

        public LARGE_INTEGER Remaining;

        [NativeTypeName("DWORD")]
        public uint BlockSize;

        [NativeTypeName("DWORD")]
        public uint PartitionCount;

        [NativeTypeName("BOOLEAN")]
        public byte WriteProtected;
    }
}
