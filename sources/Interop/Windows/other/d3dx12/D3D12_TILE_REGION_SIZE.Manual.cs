// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_TILE_REGION_SIZE
    {
        public D3D12_TILE_REGION_SIZE([NativeTypeName("UINT")] uint numTiles, [NativeTypeName("BOOL")] int useBox, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT16")] ushort height, [NativeTypeName("UINT16")] ushort depth)
        {
            NumTiles = numTiles;
            UseBox = useBox;
            Width = width;
            Height = height;
            Depth = depth;
        }
    }
}
