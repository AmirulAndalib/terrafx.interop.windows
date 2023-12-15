// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA"]/*' />
public partial struct LOGCOLORSPACEA
{
    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsSignature"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsSignature;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsVersion;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsSize;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsCSType"]/*' />
    [NativeTypeName("LCSCSTYPE")]
    public int lcsCSType;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsIntent"]/*' />
    [NativeTypeName("LCSGAMUTMATCH")]
    public int lcsIntent;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsEndpoints"]/*' />
    public CIEXYZTRIPLE lcsEndpoints;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsGammaRed"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsGammaRed;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsGammaGreen"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsGammaGreen;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsGammaBlue"]/*' />
    [NativeTypeName("DWORD")]
    public uint lcsGammaBlue;

    /// <include file='LOGCOLORSPACEA.xml' path='doc/member[@name="LOGCOLORSPACEA.lcsFilename"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _lcsFilename_e__FixedBuffer lcsFilename;

    /// <include file='_lcsFilename_e__FixedBuffer.xml' path='doc/member[@name="_lcsFilename_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _lcsFilename_e__FixedBuffer
    {
        public sbyte e0;
    }
}
