// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MKSYS
    {
        MKSYS_NONE = 0,
        MKSYS_GENERICCOMPOSITE = 1,
        MKSYS_FILEMONIKER = 2,
        MKSYS_ANTIMONIKER = 3,
        MKSYS_ITEMMONIKER = 4,
        MKSYS_POINTERMONIKER = 5,
        MKSYS_CLASSMONIKER = 7,
        MKSYS_OBJREFMONIKER = 8,
        MKSYS_SESSIONMONIKER = 9,
        MKSYS_LUAMONIKER = 10,
    }
}
