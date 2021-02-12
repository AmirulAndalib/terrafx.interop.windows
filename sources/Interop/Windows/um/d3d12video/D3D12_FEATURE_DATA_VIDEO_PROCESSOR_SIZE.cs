// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE
    {
        [NativeTypeName("UINT")]
        public uint NodeMask;

        [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc;

        [NativeTypeName("UINT")]
        public uint NumInputStreamDescs;

        [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
        public D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs;

        [NativeTypeName("UINT64")]
        public ulong MemoryPoolL0Size;

        [NativeTypeName("UINT64")]
        public ulong MemoryPoolL1Size;
    }
}
