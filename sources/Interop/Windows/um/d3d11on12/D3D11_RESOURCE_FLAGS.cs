// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_RESOURCE_FLAGS
    {
        [NativeTypeName("UINT")]
        public uint BindFlags;

        [NativeTypeName("UINT")]
        public uint MiscFlags;

        [NativeTypeName("UINT")]
        public uint CPUAccessFlags;

        [NativeTypeName("UINT")]
        public uint StructureByteStride;
    }
}
