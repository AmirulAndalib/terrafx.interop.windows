// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HORZSCROLLSTATES.xml' path='doc/member[@name="HORZSCROLLSTATES"]/*' />
public enum HORZSCROLLSTATES
{
    /// <include file='HORZSCROLLSTATES.xml' path='doc/member[@name="HORZSCROLLSTATES.HSS_NORMAL"]/*' />
    HSS_NORMAL = 1,

    /// <include file='HORZSCROLLSTATES.xml' path='doc/member[@name="HORZSCROLLSTATES.HSS_HOT"]/*' />
    HSS_HOT = 2,

    /// <include file='HORZSCROLLSTATES.xml' path='doc/member[@name="HORZSCROLLSTATES.HSS_PUSHED"]/*' />
    HSS_PUSHED = 3,

    /// <include file='HORZSCROLLSTATES.xml' path='doc/member[@name="HORZSCROLLSTATES.HSS_DISABLED"]/*' />
    HSS_DISABLED = 4,
}
