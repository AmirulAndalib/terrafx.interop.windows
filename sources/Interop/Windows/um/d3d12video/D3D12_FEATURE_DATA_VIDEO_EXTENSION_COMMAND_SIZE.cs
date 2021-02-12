// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE
    {
        [NativeTypeName("UINT")]
        public uint NodeIndex;

        [NativeTypeName("GUID")]
        public Guid CommandId;

        [NativeTypeName("const void *")]
        public void* pCreationParameters;

        [NativeTypeName("SIZE_T")]
        public nuint CreationParametersSizeInBytes;

        [NativeTypeName("UINT64")]
        public ulong MemoryPoolL0Size;

        [NativeTypeName("UINT64")]
        public ulong MemoryPoolL1Size;
    }
}
