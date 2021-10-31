// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WSAMSG
    {
        [NativeTypeName("LPSOCKADDR")]
        public SOCKADDR* name;

        public int namelen;

        [NativeTypeName("LPWSABUF")]
        public WSABUF* lpBuffers;

        [NativeTypeName("ULONG")]
        public uint dwBufferCount;

        public WSABUF Control;

        [NativeTypeName("ULONG")]
        public uint dwFlags;
    }
}
