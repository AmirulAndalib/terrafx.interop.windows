// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_VIDEO_DECODER_BUFFER_DESC
    {
        public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;

        public uint BufferIndex;

        public uint DataOffset;

        public uint DataSize;

        public uint FirstMBaddress;

        public uint NumMBsInBuffer;

        public uint Width;

        public uint Height;

        public uint Stride;

        public uint ReservedBits;

        public void* pIV;

        public uint IVSize;

        public BOOL PartialEncryption;

        public D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;
    }
}
