// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_RASTERIZER_DESC1
    {
        public D3D11_FILL_MODE FillMode;

        public D3D11_CULL_MODE CullMode;

        [NativeTypeName("BOOL")]
        public int FrontCounterClockwise;

        [NativeTypeName("INT")]
        public int DepthBias;

        [NativeTypeName("FLOAT")]
        public float DepthBiasClamp;

        [NativeTypeName("FLOAT")]
        public float SlopeScaledDepthBias;

        [NativeTypeName("BOOL")]
        public int DepthClipEnable;

        [NativeTypeName("BOOL")]
        public int ScissorEnable;

        [NativeTypeName("BOOL")]
        public int MultisampleEnable;

        [NativeTypeName("BOOL")]
        public int AntialiasedLineEnable;

        [NativeTypeName("UINT")]
        public uint ForcedSampleCount;
    }
}
