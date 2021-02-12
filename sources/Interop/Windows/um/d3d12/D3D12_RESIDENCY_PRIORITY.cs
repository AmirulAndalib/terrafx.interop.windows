// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_RESIDENCY_PRIORITY
    {
        D3D12_RESIDENCY_PRIORITY_MINIMUM = 0x28000000,
        D3D12_RESIDENCY_PRIORITY_LOW = 0x50000000,
        D3D12_RESIDENCY_PRIORITY_NORMAL = 0x78000000,
        D3D12_RESIDENCY_PRIORITY_HIGH = unchecked((int)(0xa0010000)),
        D3D12_RESIDENCY_PRIORITY_MAXIMUM = unchecked((int)(0xc8000000)),
    }
}
