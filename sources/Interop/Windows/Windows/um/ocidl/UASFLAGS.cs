// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='UASFLAGS.xml' path='doc/member[@name="UASFLAGS"]/*' />
public enum UASFLAGS
{
    /// <include file='UASFLAGS.xml' path='doc/member[@name="UASFLAGS.UAS_NORMAL"]/*' />
    UAS_NORMAL = 0,

    /// <include file='UASFLAGS.xml' path='doc/member[@name="UASFLAGS.UAS_BLOCKED"]/*' />
    UAS_BLOCKED = 0x1,

    /// <include file='UASFLAGS.xml' path='doc/member[@name="UASFLAGS.UAS_NOPARENTENABLE"]/*' />
    UAS_NOPARENTENABLE = 0x2,

    /// <include file='UASFLAGS.xml' path='doc/member[@name="UASFLAGS.UAS_MASK"]/*' />
    UAS_MASK = 0x3,
}
