// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CERT_PHYSICAL_STORE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("LPSTR")]
        public sbyte* pszOpenStoreProvider;

        [NativeTypeName("DWORD")]
        public uint dwOpenEncodingType;

        [NativeTypeName("DWORD")]
        public uint dwOpenFlags;

        public CRYPT_DATA_BLOB OpenParameters;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwPriority;
    }
}