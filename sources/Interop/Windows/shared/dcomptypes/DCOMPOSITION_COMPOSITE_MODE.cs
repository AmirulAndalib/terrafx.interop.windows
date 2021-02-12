// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DCOMPOSITION_COMPOSITE_MODE
    {
        DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER = 0,
        DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT = 1,
        DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND = 2,
        DCOMPOSITION_COMPOSITE_MODE_INHERIT = unchecked((int)(0xffffffff)),
    }
}
