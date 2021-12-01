// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYNCMGR_CONFLICT_ITEM_TYPE.xml' path='doc/member[@name="SYNCMGR_CONFLICT_ITEM_TYPE"]/*' />
public enum SYNCMGR_CONFLICT_ITEM_TYPE
{
    /// <include file='SYNCMGR_CONFLICT_ITEM_TYPE.xml' path='doc/member[@name="SYNCMGR_CONFLICT_ITEM_TYPE.SYNCMGR_CIT_UPDATED"]/*' />
    SYNCMGR_CIT_UPDATED = 0x1,

    /// <include file='SYNCMGR_CONFLICT_ITEM_TYPE.xml' path='doc/member[@name="SYNCMGR_CONFLICT_ITEM_TYPE.SYNCMGR_CIT_DELETED"]/*' />
    SYNCMGR_CIT_DELETED = 0x2,
}
