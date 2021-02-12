// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SI_COPYFILE
    {
        [NativeTypeName("DWORD")]
        public uint SourceFileNameLength;

        [NativeTypeName("DWORD")]
        public uint DestinationFileNameLength;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileNameBuffer[1];
    }
}
