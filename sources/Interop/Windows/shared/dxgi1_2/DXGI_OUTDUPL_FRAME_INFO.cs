// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_OUTDUPL_FRAME_INFO
    {
        public LARGE_INTEGER LastPresentTime;

        public LARGE_INTEGER LastMouseUpdateTime;

        [NativeTypeName("UINT")]
        public uint AccumulatedFrames;

        [NativeTypeName("BOOL")]
        public int RectsCoalesced;

        [NativeTypeName("BOOL")]
        public int ProtectedContentMaskedOut;

        public DXGI_OUTDUPL_POINTER_POSITION PointerPosition;

        [NativeTypeName("UINT")]
        public uint TotalMetadataBufferSize;

        [NativeTypeName("UINT")]
        public uint PointerShapeBufferSize;
    }
}
