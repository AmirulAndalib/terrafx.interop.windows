// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPRULESTATE
    {
        SPRS_INACTIVE = 0,
        SPRS_ACTIVE = 1,
        SPRS_ACTIVE_WITH_AUTO_PAUSE = 3,
        SPRS_ACTIVE_USER_DELIMITED = 4,
    }
}
