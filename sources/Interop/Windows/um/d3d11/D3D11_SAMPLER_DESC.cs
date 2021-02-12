// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_SAMPLER_DESC
    {
        public D3D11_FILTER Filter;

        public D3D11_TEXTURE_ADDRESS_MODE AddressU;

        public D3D11_TEXTURE_ADDRESS_MODE AddressV;

        public D3D11_TEXTURE_ADDRESS_MODE AddressW;

        [NativeTypeName("FLOAT")]
        public float MipLODBias;

        [NativeTypeName("UINT")]
        public uint MaxAnisotropy;

        public D3D11_COMPARISON_FUNC ComparisonFunc;

        [NativeTypeName("FLOAT [4]")]
        public fixed float BorderColor[4];

        [NativeTypeName("FLOAT")]
        public float MinLOD;

        [NativeTypeName("FLOAT")]
        public float MaxLOD;
    }
}
