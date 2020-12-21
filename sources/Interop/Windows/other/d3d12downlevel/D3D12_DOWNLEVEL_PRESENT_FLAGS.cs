// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_DOWNLEVEL_PRESENT_FLAGS
    {
        D3D12_DOWNLEVEL_PRESENT_FLAG_NONE = 0,
        D3D12_DOWNLEVEL_PRESENT_FLAG_WAIT_FOR_VBLANK = (D3D12_DOWNLEVEL_PRESENT_FLAG_NONE + 1),
    }
}
