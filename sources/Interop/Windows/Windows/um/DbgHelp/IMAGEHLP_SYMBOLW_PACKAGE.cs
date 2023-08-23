// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_SYMBOLW_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW_PACKAGE"]/*' />
public unsafe partial struct IMAGEHLP_SYMBOLW_PACKAGE
{
    /// <include file='IMAGEHLP_SYMBOLW_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW_PACKAGE.sym"]/*' />
    public IMAGEHLP_SYMBOLW sym;

    /// <include file='IMAGEHLP_SYMBOLW_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW_PACKAGE.name"]/*' />
    [NativeTypeName("WCHAR[2001]")]
    public fixed char name[2001];
}
