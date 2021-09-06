// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum HLNF
    {
        HLNF_INTERNALJUMP = 0x1,
        HLNF_OPENINNEWWINDOW = 0x2,
        HLNF_NAVIGATINGBACK = 0x4,
        HLNF_NAVIGATINGFORWARD = 0x8,
        HLNF_NAVIGATINGTOSTACKITEM = 0x10,
        HLNF_CREATENOHISTORY = 0x20,
    }
}
