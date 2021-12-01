// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ASSOCKEY.xml' path='doc/member[@name="ASSOCKEY"]/*' />
public enum ASSOCKEY
{
    /// <include file='ASSOCKEY.xml' path='doc/member[@name="ASSOCKEY.ASSOCKEY_SHELLEXECCLASS"]/*' />
    ASSOCKEY_SHELLEXECCLASS = 1,

    /// <include file='ASSOCKEY.xml' path='doc/member[@name="ASSOCKEY.ASSOCKEY_APP"]/*' />
    ASSOCKEY_APP,

    /// <include file='ASSOCKEY.xml' path='doc/member[@name="ASSOCKEY.ASSOCKEY_CLASS"]/*' />
    ASSOCKEY_CLASS,

    /// <include file='ASSOCKEY.xml' path='doc/member[@name="ASSOCKEY.ASSOCKEY_BASECLASS"]/*' />
    ASSOCKEY_BASECLASS,

    /// <include file='ASSOCKEY.xml' path='doc/member[@name="ASSOCKEY.ASSOCKEY_MAX"]/*' />
    ASSOCKEY_MAX,
}
