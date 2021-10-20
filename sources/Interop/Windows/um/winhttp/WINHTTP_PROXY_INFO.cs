// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WINHTTP_PROXY_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwAccessType;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszProxy;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszProxyBypass;
    }
}