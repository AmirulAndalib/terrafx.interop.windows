// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='EMRCREATECOLORSPACEW.xml' path='doc/member[@name="EMRCREATECOLORSPACEW"]/*' />
public unsafe partial struct EMRCREATECOLORSPACEW
{
    /// <include file='EMRCREATECOLORSPACEW.xml' path='doc/member[@name="EMRCREATECOLORSPACEW.emr"]/*' />
    public EMR emr;

    /// <include file='EMRCREATECOLORSPACEW.xml' path='doc/member[@name="EMRCREATECOLORSPACEW.ihCS"]/*' />
    [NativeTypeName("DWORD")]
    public uint ihCS;

    /// <include file='EMRCREATECOLORSPACEW.xml' path='doc/member[@name="EMRCREATECOLORSPACEW.lcs"]/*' />
    public LOGCOLORSPACEW lcs;

    /// <include file='EMRCREATECOLORSPACEW.xml' path='doc/member[@name="EMRCREATECOLORSPACEW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='EMRCREATECOLORSPACEW.xml' path='doc/member[@name="EMRCREATECOLORSPACEW.cbData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbData;

    /// <include file='EMRCREATECOLORSPACEW.xml' path='doc/member[@name="EMRCREATECOLORSPACEW.Data"]/*' />
    [NativeTypeName("BYTE [1]")]
    public fixed byte Data[1];
}
