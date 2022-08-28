// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DIRECTMANIPULATION_DRAG_DROP_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_STATUS"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum DIRECTMANIPULATION_DRAG_DROP_STATUS
{
    /// <include file='DIRECTMANIPULATION_DRAG_DROP_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_STATUS.DIRECTMANIPULATION_DRAG_DROP_READY"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_READY = 0,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_STATUS.DIRECTMANIPULATION_DRAG_DROP_PRESELECT"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_PRESELECT = 1,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_STATUS.DIRECTMANIPULATION_DRAG_DROP_SELECTING"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_SELECTING = 2,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_STATUS.DIRECTMANIPULATION_DRAG_DROP_DRAGGING"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_DRAGGING = 3,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_STATUS.DIRECTMANIPULATION_DRAG_DROP_CANCELLED"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_CANCELLED = 4,

    /// <include file='DIRECTMANIPULATION_DRAG_DROP_STATUS.xml' path='doc/member[@name="DIRECTMANIPULATION_DRAG_DROP_STATUS.DIRECTMANIPULATION_DRAG_DROP_COMMITTED"]/*' />
    DIRECTMANIPULATION_DRAG_DROP_COMMITTED = 5,
}
