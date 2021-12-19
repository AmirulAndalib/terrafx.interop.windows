// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CLOSESTATES.xml' path='doc/member[@name="CLOSESTATES"]/*' />
public enum CLOSESTATES
{
    /// <include file='CLOSESTATES.xml' path='doc/member[@name="CLOSESTATES.TTCS_NORMAL"]/*' />
    TTCS_NORMAL = 1,

    /// <include file='CLOSESTATES.xml' path='doc/member[@name="CLOSESTATES.TTCS_HOT"]/*' />
    TTCS_HOT = 2,

    /// <include file='CLOSESTATES.xml' path='doc/member[@name="CLOSESTATES.TTCS_PRESSED"]/*' />
    TTCS_PRESSED = 3,
}
