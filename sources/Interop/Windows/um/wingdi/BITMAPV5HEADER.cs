// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct BITMAPV5HEADER
    {
        [NativeTypeName("DWORD")]
        public uint bV5Size;

        [NativeTypeName("LONG")]
        public int bV5Width;

        [NativeTypeName("LONG")]
        public int bV5Height;

        [NativeTypeName("WORD")]
        public ushort bV5Planes;

        [NativeTypeName("WORD")]
        public ushort bV5BitCount;

        [NativeTypeName("DWORD")]
        public uint bV5Compression;

        [NativeTypeName("DWORD")]
        public uint bV5SizeImage;

        [NativeTypeName("LONG")]
        public int bV5XPelsPerMeter;

        [NativeTypeName("LONG")]
        public int bV5YPelsPerMeter;

        [NativeTypeName("DWORD")]
        public uint bV5ClrUsed;

        [NativeTypeName("DWORD")]
        public uint bV5ClrImportant;

        [NativeTypeName("DWORD")]
        public uint bV5RedMask;

        [NativeTypeName("DWORD")]
        public uint bV5GreenMask;

        [NativeTypeName("DWORD")]
        public uint bV5BlueMask;

        [NativeTypeName("DWORD")]
        public uint bV5AlphaMask;

        [NativeTypeName("DWORD")]
        public uint bV5CSType;

        public CIEXYZTRIPLE bV5Endpoints;

        [NativeTypeName("DWORD")]
        public uint bV5GammaRed;

        [NativeTypeName("DWORD")]
        public uint bV5GammaGreen;

        [NativeTypeName("DWORD")]
        public uint bV5GammaBlue;

        [NativeTypeName("DWORD")]
        public uint bV5Intent;

        [NativeTypeName("DWORD")]
        public uint bV5ProfileData;

        [NativeTypeName("DWORD")]
        public uint bV5ProfileSize;

        [NativeTypeName("DWORD")]
        public uint bV5Reserved;
    }
}
