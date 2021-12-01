// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='BINDHANDLETYPES.xml' path='doc/member[@name="BINDHANDLETYPES"]/*' />
public enum BINDHANDLETYPES
{
    /// <include file='BINDHANDLETYPES.xml' path='doc/member[@name="BINDHANDLETYPES.BINDHANDLETYPES_APPCACHE"]/*' />
    BINDHANDLETYPES_APPCACHE = 0,

    /// <include file='BINDHANDLETYPES.xml' path='doc/member[@name="BINDHANDLETYPES.BINDHANDLETYPES_DEPENDENCY"]/*' />
    BINDHANDLETYPES_DEPENDENCY = 0x1,

    /// <include file='BINDHANDLETYPES.xml' path='doc/member[@name="BINDHANDLETYPES.BINDHANDLETYPES_COUNT"]/*' />
    BINDHANDLETYPES_COUNT = (BINDHANDLETYPES_DEPENDENCY + 1),
}
