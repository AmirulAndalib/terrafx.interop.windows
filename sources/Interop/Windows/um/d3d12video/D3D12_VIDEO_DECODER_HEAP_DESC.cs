// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_VIDEO_DECODER_HEAP_DESC
    {
        [NativeTypeName("UINT")]
        public uint NodeMask;

        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;

        [NativeTypeName("UINT")]
        public uint DecodeWidth;

        [NativeTypeName("UINT")]
        public uint DecodeHeight;

        public DXGI_FORMAT Format;

        public DXGI_RATIONAL FrameRate;

        [NativeTypeName("UINT")]
        public uint BitRate;

        [NativeTypeName("UINT")]
        public uint MaxDecodePictureBufferCount;
    }
}
