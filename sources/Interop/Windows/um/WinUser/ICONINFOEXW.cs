// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct ICONINFOEXW
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("BOOL")]
        public int fIcon;

        [NativeTypeName("DWORD")]
        public uint xHotspot;

        [NativeTypeName("DWORD")]
        public uint yHotspot;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmMask;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmColor;

        [NativeTypeName("WORD")]
        public ushort wResID;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szModName[260];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szResName[260];
    }
}
