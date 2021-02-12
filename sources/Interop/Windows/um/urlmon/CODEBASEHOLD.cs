// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CODEBASEHOLD
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("LPWSTR")]
        public ushort* szDistUnit;

        [NativeTypeName("LPWSTR")]
        public ushort* szCodeBase;

        [NativeTypeName("DWORD")]
        public uint dwVersionMS;

        [NativeTypeName("DWORD")]
        public uint dwVersionLS;

        [NativeTypeName("DWORD")]
        public uint dwStyle;
    }
}
