// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCAPS
{
    [NativeTypeName("#define D3DCAPS_OVERLAY 0x00000800L")]
    public const int D3DCAPS_OVERLAY = 0x00000800;

    [NativeTypeName("#define D3DCAPS_READ_SCANLINE 0x00020000L")]
    public const int D3DCAPS_READ_SCANLINE = 0x00020000;
}
