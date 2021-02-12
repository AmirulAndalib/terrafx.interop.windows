// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D11_COLOR_WRITE_ENABLE
    {
        D3D11_COLOR_WRITE_ENABLE_RED = 1,
        D3D11_COLOR_WRITE_ENABLE_GREEN = 2,
        D3D11_COLOR_WRITE_ENABLE_BLUE = 4,
        D3D11_COLOR_WRITE_ENABLE_ALPHA = 8,
        D3D11_COLOR_WRITE_ENABLE_ALL = (((D3D11_COLOR_WRITE_ENABLE_RED | D3D11_COLOR_WRITE_ENABLE_GREEN) | D3D11_COLOR_WRITE_ENABLE_BLUE) | D3D11_COLOR_WRITE_ENABLE_ALPHA),
    }
}
