// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum TRAILINGGRIDCELLUPPERSTATES
    {
        MCTGCU_HOT = 1,
        MCTGCU_HASSTATE = 2,
        MCTGCU_HASSTATEHOT = 3,
        MCTGCU_SELECTED = 4,
        MCTGCU_SELECTEDHOT = 5,
    }
}