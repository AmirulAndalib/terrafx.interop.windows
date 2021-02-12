// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct OFSTRUCT
    {
        [NativeTypeName("BYTE")]
        public byte cBytes;

        [NativeTypeName("BYTE")]
        public byte fFixedDisk;

        [NativeTypeName("WORD")]
        public ushort nErrCode;

        [NativeTypeName("WORD")]
        public ushort Reserved1;

        [NativeTypeName("WORD")]
        public ushort Reserved2;

        [NativeTypeName("CHAR [128]")]
        public fixed sbyte szPathName[128];
    }
}
