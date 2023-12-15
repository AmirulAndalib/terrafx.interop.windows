// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW"]/*' />
public partial struct LOGFONTW
{
    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfHeight"]/*' />
    [NativeTypeName("LONG")]
    public int lfHeight;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfWidth"]/*' />
    [NativeTypeName("LONG")]
    public int lfWidth;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfEscapement"]/*' />
    [NativeTypeName("LONG")]
    public int lfEscapement;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfOrientation"]/*' />
    [NativeTypeName("LONG")]
    public int lfOrientation;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfWeight"]/*' />
    [NativeTypeName("LONG")]
    public int lfWeight;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfItalic"]/*' />
    public byte lfItalic;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfUnderline"]/*' />
    public byte lfUnderline;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfStrikeOut"]/*' />
    public byte lfStrikeOut;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfCharSet"]/*' />
    public byte lfCharSet;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfOutPrecision"]/*' />
    public byte lfOutPrecision;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfClipPrecision"]/*' />
    public byte lfClipPrecision;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfQuality"]/*' />
    public byte lfQuality;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfPitchAndFamily"]/*' />
    public byte lfPitchAndFamily;

    /// <include file='LOGFONTW.xml' path='doc/member[@name="LOGFONTW.lfFaceName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _lfFaceName_e__FixedBuffer lfFaceName;

    /// <include file='_lfFaceName_e__FixedBuffer.xml' path='doc/member[@name="_lfFaceName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _lfFaceName_e__FixedBuffer
    {
        public char e0;
    }
}
