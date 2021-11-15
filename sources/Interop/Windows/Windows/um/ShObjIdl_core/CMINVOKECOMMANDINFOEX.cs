// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CMINVOKECOMMANDINFOEX
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint fMask;

        public HWND hwnd;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpVerb;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpParameters;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpDirectory;

        public int nShow;

        [NativeTypeName("DWORD")]
        public uint dwHotKey;

        public HANDLE hIcon;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpTitle;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpVerbW;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpParametersW;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpDirectoryW;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpTitleW;

        public POINT ptInvoke;
    }
}