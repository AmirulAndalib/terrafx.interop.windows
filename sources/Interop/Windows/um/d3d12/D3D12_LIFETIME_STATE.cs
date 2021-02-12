// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_LIFETIME_STATE
    {
        D3D12_LIFETIME_STATE_IN_USE = 0,
        D3D12_LIFETIME_STATE_NOT_IN_USE = (D3D12_LIFETIME_STATE_IN_USE + 1),
    }
}
