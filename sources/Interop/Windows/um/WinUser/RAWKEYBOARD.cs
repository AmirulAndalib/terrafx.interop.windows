// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RAWKEYBOARD
    {
        public ushort MakeCode;

        public ushort Flags;

        public ushort Reserved;

        public ushort VKey;

        public uint Message;

        [NativeTypeName("ULONG")]
        public uint ExtraInformation;
    }
}
