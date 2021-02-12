// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_SHADER_BUFFER_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        public D3D_CBUFFER_TYPE Type;

        [NativeTypeName("UINT")]
        public uint Variables;

        [NativeTypeName("UINT")]
        public uint Size;

        [NativeTypeName("UINT")]
        public uint uFlags;
    }
}
