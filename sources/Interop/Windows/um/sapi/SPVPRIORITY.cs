// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPVPRIORITY
    {
        SPVPRI_NORMAL = 0,
        SPVPRI_ALERT = (1 << 0),
        SPVPRI_OVER = (1 << 1),
    }
}
