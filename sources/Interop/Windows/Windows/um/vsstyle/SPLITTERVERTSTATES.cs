// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SPLITTERVERTSTATES.xml' path='doc/member[@name="SPLITTERVERTSTATES"]/*' />
public enum SPLITTERVERTSTATES
{
    /// <include file='SPLITTERVERTSTATES.xml' path='doc/member[@name="SPLITTERVERTSTATES.SPLITSV_NORMAL"]/*' />
    SPLITSV_NORMAL = 1,

    /// <include file='SPLITTERVERTSTATES.xml' path='doc/member[@name="SPLITTERVERTSTATES.SPLITSV_HOT"]/*' />
    SPLITSV_HOT = 2,

    /// <include file='SPLITTERVERTSTATES.xml' path='doc/member[@name="SPLITTERVERTSTATES.SPLITSV_PRESSED"]/*' />
    SPLITSV_PRESSED = 3,
}
