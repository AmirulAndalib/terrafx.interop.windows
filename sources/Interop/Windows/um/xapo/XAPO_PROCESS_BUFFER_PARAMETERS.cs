// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct XAPO_PROCESS_BUFFER_PARAMETERS
    {
        [NativeTypeName("void *")]
        public void* pBuffer;

        public XAPO_BUFFER_FLAGS BufferFlags;

        [NativeTypeName("UINT32")]
        public uint ValidFrameCount;
    }
}
