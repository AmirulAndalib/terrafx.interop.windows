// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX;

public partial struct D2D1_CREATION_PROPERTIES
{
    public D2D1_CREATION_PROPERTIES(D2D1_THREADING_MODE threadingMode, D2D1_DEBUG_LEVEL debugLevel, D2D1_DEVICE_CONTEXT_OPTIONS options)
    {
        this = CreationProperties(threadingMode, debugLevel, options);
    }
}
