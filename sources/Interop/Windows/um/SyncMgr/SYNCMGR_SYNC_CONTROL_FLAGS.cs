// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SYNCMGR_SYNC_CONTROL_FLAGS
    {
        SYNCMGR_SCF_NONE = 0,
        SYNCMGR_SCF_IGNORE_IF_ALREADY_SYNCING = 0x1,
        SYNCMGR_SCF_VALID = 0x1,
    }
}