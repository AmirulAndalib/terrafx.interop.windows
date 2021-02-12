// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DIBSECTION
    {
        public BITMAP dsBm;

        public BITMAPINFOHEADER dsBmih;

        [NativeTypeName("DWORD [3]")]
        public fixed uint dsBitfields[3];

        [NativeTypeName("HANDLE")]
        public IntPtr dshSection;

        [NativeTypeName("DWORD")]
        public uint dsOffset;
    }
}
