// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AM_INTF_SEARCH_FLAGS
    {
        AM_INTF_SEARCH_INPUT_PIN = 0x1,
        AM_INTF_SEARCH_OUTPUT_PIN = 0x2,
        AM_INTF_SEARCH_FILTER = 0x4,
    }
}
