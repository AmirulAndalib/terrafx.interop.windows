// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DXGI_OUTDUPL_POINTER_SHAPE_TYPE
    {
        DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MONOCHROME = 0x1,
        DXGI_OUTDUPL_POINTER_SHAPE_TYPE_COLOR = 0x2,
        DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MASKED_COLOR = 0x4,
    }
}
