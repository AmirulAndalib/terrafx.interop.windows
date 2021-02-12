// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D11_TILE_RANGE_FLAG
    {
        D3D11_TILE_RANGE_NULL = 0x1,
        D3D11_TILE_RANGE_SKIP = 0x2,
        D3D11_TILE_RANGE_REUSE_SINGLE_TILE = 0x4,
    }
}
