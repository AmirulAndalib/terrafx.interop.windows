// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public enum THUNK_ORDINAL
    {
        THUNK_ORDINAL_NOTYPE,
        THUNK_ORDINAL_ADJUSTOR,
        THUNK_ORDINAL_VCALL,
        THUNK_ORDINAL_PCODE,
        THUNK_ORDINAL_LOAD,
        THUNK_ORDINAL_TRAMP_INCREMENTAL,
        THUNK_ORDINAL_TRAMP_BRANCHISLAND,
        THUNK_ORDINAL_TRAMP_STRICTICF,
    }
}