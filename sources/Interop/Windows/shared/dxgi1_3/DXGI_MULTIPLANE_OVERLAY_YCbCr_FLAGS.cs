// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS
    {
        DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_NOMINAL_RANGE = 0x1,
        DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_BT709 = 0x2,
        DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_xvYCC = 0x4,
    }
}
