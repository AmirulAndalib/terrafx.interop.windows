// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct STATSTG
    {
        [NativeTypeName("LPOLESTR")]
        public ushort* pwcsName;

        [NativeTypeName("DWORD")]
        public uint type;

        public ULARGE_INTEGER cbSize;

        public FILETIME mtime;

        public FILETIME ctime;

        public FILETIME atime;

        [NativeTypeName("DWORD")]
        public uint grfMode;

        [NativeTypeName("DWORD")]
        public uint grfLocksSupported;

        [NativeTypeName("CLSID")]
        public Guid clsid;

        [NativeTypeName("DWORD")]
        public uint grfStateBits;

        [NativeTypeName("DWORD")]
        public uint reserved;
    }
}
