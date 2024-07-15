// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_SYMBOLW64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64_PACKAGE"]/*' />
public partial struct IMAGEHLP_SYMBOLW64_PACKAGE
{
    /// <include file='IMAGEHLP_SYMBOLW64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64_PACKAGE.sym"]/*' />
    public IMAGEHLP_SYMBOLW64 sym;

    /// <include file='IMAGEHLP_SYMBOLW64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64_PACKAGE.name"]/*' />
    [NativeTypeName("WCHAR[2001]")]
    public _name_e__FixedBuffer name;

    /// <include file='_name_e__FixedBuffer.xml' path='doc/member[@name="_name_e__FixedBuffer"]/*' />
    [InlineArray(2001)]
    public partial struct _name_e__FixedBuffer
    {
        public char e0;
    }
}
