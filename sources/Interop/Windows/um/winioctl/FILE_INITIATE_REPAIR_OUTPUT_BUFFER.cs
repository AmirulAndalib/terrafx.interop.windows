// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FILE_INITIATE_REPAIR_OUTPUT_BUFFER
    {
        [NativeTypeName("DWORDLONG")]
        public ulong Hint1;

        [NativeTypeName("DWORDLONG")]
        public ulong Hint2;

        [NativeTypeName("CLSN")]
        public ulong Clsn;

        [NativeTypeName("DWORD")]
        public uint Status;
    }
}
