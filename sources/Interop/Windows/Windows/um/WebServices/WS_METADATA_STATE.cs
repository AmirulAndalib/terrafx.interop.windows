// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_METADATA_STATE.xml' path='doc/member[@name="WS_METADATA_STATE"]/*' />
public enum WS_METADATA_STATE
{
    /// <include file='WS_METADATA_STATE.xml' path='doc/member[@name="WS_METADATA_STATE.WS_METADATA_STATE_CREATED"]/*' />
    WS_METADATA_STATE_CREATED = 1,

    /// <include file='WS_METADATA_STATE.xml' path='doc/member[@name="WS_METADATA_STATE.WS_METADATA_STATE_RESOLVED"]/*' />
    WS_METADATA_STATE_RESOLVED = 2,

    /// <include file='WS_METADATA_STATE.xml' path='doc/member[@name="WS_METADATA_STATE.WS_METADATA_STATE_FAULTED"]/*' />
    WS_METADATA_STATE_FAULTED = 3,
}
