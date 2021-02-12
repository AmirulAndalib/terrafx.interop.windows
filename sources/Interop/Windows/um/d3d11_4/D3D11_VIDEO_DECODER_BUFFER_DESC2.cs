// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_VIDEO_DECODER_BUFFER_DESC2
    {
        public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;

        [NativeTypeName("UINT")]
        public uint DataOffset;

        [NativeTypeName("UINT")]
        public uint DataSize;

        [NativeTypeName("void *")]
        public void* pIV;

        [NativeTypeName("UINT")]
        public uint IVSize;

        [NativeTypeName("D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK *")]
        public D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK* pSubSampleMappingBlock;

        [NativeTypeName("UINT")]
        public uint SubSampleMappingCount;

        [NativeTypeName("UINT")]
        public uint cBlocksStripeEncrypted;

        [NativeTypeName("UINT")]
        public uint cBlocksStripeClear;
    }
}
