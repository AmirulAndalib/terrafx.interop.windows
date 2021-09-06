// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum HOMEGROUPSHARINGCHOICES
    {
        HGSC_NONE = 0,
        HGSC_MUSICLIBRARY = 0x1,
        HGSC_PICTURESLIBRARY = 0x2,
        HGSC_VIDEOSLIBRARY = 0x4,
        HGSC_DOCUMENTSLIBRARY = 0x8,
        HGSC_PRINTERS = 0x10,
    }
}
