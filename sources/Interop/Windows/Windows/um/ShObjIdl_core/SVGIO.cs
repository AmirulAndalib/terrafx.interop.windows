// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SVGIO
    {
        SVGIO_BACKGROUND = 0,
        SVGIO_SELECTION = 0x1,
        SVGIO_ALLVIEW = 0x2,
        SVGIO_CHECKED = 0x3,
        SVGIO_TYPE_MASK = 0xf,
        SVGIO_FLAG_VIEWORDER = unchecked((int)(0x80000000)),
    }
}