// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum OfflineFolderStatus
    {
        OFS_INACTIVE = -1,
        OFS_ONLINE = (OFS_INACTIVE + 1),
        OFS_OFFLINE = (OFS_ONLINE + 1),
        OFS_SERVERBACK = (OFS_OFFLINE + 1),
        OFS_DIRTYCACHE = (OFS_SERVERBACK + 1),
    }
}