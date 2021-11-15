// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SYNCMGR_RESOLUTION_ABILITIES
    {
        SYNCMGR_RA_KEEPOTHER = 0x1,
        SYNCMGR_RA_KEEPRECENT = 0x2,
        SYNCMGR_RA_REMOVEFROMSYNCSET = 0x4,
        SYNCMGR_RA_KEEP_SINGLE = 0x8,
        SYNCMGR_RA_KEEP_MULTIPLE = 0x10,
        SYNCMGR_RA_VALID = 0x1f,
    }
}