// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='EDITBORDER_VSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_VSCROLLSTATES"]/*' />
public enum EDITBORDER_VSCROLLSTATES
{
    /// <include file='EDITBORDER_VSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_VSCROLLSTATES.EPSV_NORMAL"]/*' />
    EPSV_NORMAL = 1,

    /// <include file='EDITBORDER_VSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_VSCROLLSTATES.EPSV_HOT"]/*' />
    EPSV_HOT = 2,

    /// <include file='EDITBORDER_VSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_VSCROLLSTATES.EPSV_FOCUSED"]/*' />
    EPSV_FOCUSED = 3,

    /// <include file='EDITBORDER_VSCROLLSTATES.xml' path='doc/member[@name="EDITBORDER_VSCROLLSTATES.EPSV_DISABLED"]/*' />
    EPSV_DISABLED = 4,
}
