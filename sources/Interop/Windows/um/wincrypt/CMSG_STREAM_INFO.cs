// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_STREAM_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbContent;

        [NativeTypeName("PFN_CMSG_STREAM_OUTPUT")]
        public IntPtr pfnStreamOutput;

        [NativeTypeName("void *")]
        public void* pvArg;
    }
}