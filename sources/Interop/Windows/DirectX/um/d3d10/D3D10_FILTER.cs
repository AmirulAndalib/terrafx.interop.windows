// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX
{
    [Flags]
    public enum D3D10_FILTER
    {
        D3D10_FILTER_MIN_MAG_MIP_POINT = 0,
        D3D10_FILTER_MIN_MAG_POINT_MIP_LINEAR = 0x1,
        D3D10_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x4,
        D3D10_FILTER_MIN_POINT_MAG_MIP_LINEAR = 0x5,
        D3D10_FILTER_MIN_LINEAR_MAG_MIP_POINT = 0x10,
        D3D10_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x11,
        D3D10_FILTER_MIN_MAG_LINEAR_MIP_POINT = 0x14,
        D3D10_FILTER_MIN_MAG_MIP_LINEAR = 0x15,
        D3D10_FILTER_ANISOTROPIC = 0x55,
        D3D10_FILTER_COMPARISON_MIN_MAG_MIP_POINT = 0x80,
        D3D10_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR = 0x81,
        D3D10_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT = 0x84,
        D3D10_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR = 0x85,
        D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT = 0x90,
        D3D10_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR = 0x91,
        D3D10_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT = 0x94,
        D3D10_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR = 0x95,
        D3D10_FILTER_COMPARISON_ANISOTROPIC = 0xd5,
        D3D10_FILTER_TEXT_1BIT = unchecked((int)(0x80000000)),
    }
}