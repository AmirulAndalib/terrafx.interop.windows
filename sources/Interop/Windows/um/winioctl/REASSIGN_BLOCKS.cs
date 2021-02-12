// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct REASSIGN_BLOCKS
    {
        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("WORD")]
        public ushort Count;

        [NativeTypeName("DWORD [1]")]
        public fixed uint BlockNumber[1];
    }
}
