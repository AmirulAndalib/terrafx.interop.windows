// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LOGCOLORSPACEW
    {
        [NativeTypeName("DWORD")]
        public uint lcsSignature;

        [NativeTypeName("DWORD")]
        public uint lcsVersion;

        [NativeTypeName("DWORD")]
        public uint lcsSize;

        [NativeTypeName("LCSCSTYPE")]
        public int lcsCSType;

        [NativeTypeName("LCSGAMUTMATCH")]
        public int lcsIntent;

        public CIEXYZTRIPLE lcsEndpoints;

        [NativeTypeName("DWORD")]
        public uint lcsGammaRed;

        [NativeTypeName("DWORD")]
        public uint lcsGammaGreen;

        [NativeTypeName("DWORD")]
        public uint lcsGammaBlue;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort lcsFilename[260];
    }
}
