// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    [Flags]
    public enum EXPLORER_BROWSER_FILL_FLAGS
    {
        EBF_NONE = 0,
        EBF_SELECTFROMDATAOBJECT = 0x100,
        EBF_NODROPTARGET = 0x200,
    }
}