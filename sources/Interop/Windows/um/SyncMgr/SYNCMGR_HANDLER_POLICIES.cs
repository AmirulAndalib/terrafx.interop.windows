// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SYNCMGR_HANDLER_POLICIES
    {
        SYNCMGR_HPM_NONE = 0,
        SYNCMGR_HPM_PREVENT_ACTIVATE = 0x1,
        SYNCMGR_HPM_PREVENT_DEACTIVATE = 0x2,
        SYNCMGR_HPM_PREVENT_ENABLE = 0x4,
        SYNCMGR_HPM_PREVENT_DISABLE = 0x8,
        SYNCMGR_HPM_PREVENT_START_SYNC = 0x10,
        SYNCMGR_HPM_PREVENT_STOP_SYNC = 0x20,
        SYNCMGR_HPM_DISABLE_ENABLE = 0x100,
        SYNCMGR_HPM_DISABLE_DISABLE = 0x200,
        SYNCMGR_HPM_DISABLE_START_SYNC = 0x400,
        SYNCMGR_HPM_DISABLE_STOP_SYNC = 0x800,
        SYNCMGR_HPM_DISABLE_BROWSE = 0x1000,
        SYNCMGR_HPM_DISABLE_SCHEDULE = 0x2000,
        SYNCMGR_HPM_HIDDEN_BY_DEFAULT = 0x10000,
        SYNCMGR_HPM_BACKGROUND_SYNC_ONLY = (SYNCMGR_HPM_PREVENT_START_SYNC | SYNCMGR_HPM_PREVENT_STOP_SYNC),
        SYNCMGR_HPM_VALID_MASK = 0x12f3f,
    }
}
