// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DXGI_OFFER_RESOURCE_FLAGS
    {
        DXGI_OFFER_RESOURCE_FLAG_ALLOW_DECOMMIT = 0x1,
    }
}
