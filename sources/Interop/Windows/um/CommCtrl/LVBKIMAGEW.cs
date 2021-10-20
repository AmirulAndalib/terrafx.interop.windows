// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct LVBKIMAGEW
    {
        [NativeTypeName("ULONG")]
        public uint ulFlags;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbm;

        [NativeTypeName("LPWSTR")]
        public ushort* pszImage;

        [NativeTypeName("UINT")]
        public uint cchImageMax;

        public int xOffsetPercent;

        public int yOffsetPercent;
    }
}