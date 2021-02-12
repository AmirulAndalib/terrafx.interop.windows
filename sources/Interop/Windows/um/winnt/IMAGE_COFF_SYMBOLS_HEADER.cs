// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct IMAGE_COFF_SYMBOLS_HEADER
    {
        [NativeTypeName("DWORD")]
        public uint NumberOfSymbols;

        [NativeTypeName("DWORD")]
        public uint LvaToFirstSymbol;

        [NativeTypeName("DWORD")]
        public uint NumberOfLinenumbers;

        [NativeTypeName("DWORD")]
        public uint LvaToFirstLinenumber;

        [NativeTypeName("DWORD")]
        public uint RvaToFirstByteOfCode;

        [NativeTypeName("DWORD")]
        public uint RvaToLastByteOfCode;

        [NativeTypeName("DWORD")]
        public uint RvaToFirstByteOfData;

        [NativeTypeName("DWORD")]
        public uint RvaToLastByteOfData;
    }
}
