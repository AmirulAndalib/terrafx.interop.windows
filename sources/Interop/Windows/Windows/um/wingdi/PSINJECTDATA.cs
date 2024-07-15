// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PSINJECTDATA.xml' path='doc/member[@name="PSINJECTDATA"]/*' />
public partial struct PSINJECTDATA
{
    /// <include file='PSINJECTDATA.xml' path='doc/member[@name="PSINJECTDATA.DataBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataBytes;

    /// <include file='PSINJECTDATA.xml' path='doc/member[@name="PSINJECTDATA.InjectionPoint"]/*' />
    [NativeTypeName("WORD")]
    public ushort InjectionPoint;

    /// <include file='PSINJECTDATA.xml' path='doc/member[@name="PSINJECTDATA.PageNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort PageNumber;
}
