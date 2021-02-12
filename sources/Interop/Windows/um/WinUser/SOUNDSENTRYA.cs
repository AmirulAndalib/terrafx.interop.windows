// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SOUNDSENTRYA
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffect;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffectMSec;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffectColorBits;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffect;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectMSec;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectColor;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffect;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffectMSec;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszWindowsEffectDLL;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffectOrdinal;
    }
}
