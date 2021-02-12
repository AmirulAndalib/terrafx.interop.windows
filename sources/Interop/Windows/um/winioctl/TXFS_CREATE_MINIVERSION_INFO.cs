// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TXFS_CREATE_MINIVERSION_INFO
    {
        [NativeTypeName("WORD")]
        public ushort StructureVersion;

        [NativeTypeName("WORD")]
        public ushort StructureLength;

        [NativeTypeName("DWORD")]
        public uint BaseVersion;

        [NativeTypeName("WORD")]
        public ushort MiniVersion;
    }
}
