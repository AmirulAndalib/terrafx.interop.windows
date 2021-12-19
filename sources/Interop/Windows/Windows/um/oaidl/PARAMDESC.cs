// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PARAMDESC.xml' path='doc/member[@name="PARAMDESC"]/*' />
public unsafe partial struct PARAMDESC
{
    /// <include file='PARAMDESC.xml' path='doc/member[@name="PARAMDESC.pparamdescex"]/*' />
    [NativeTypeName("LPPARAMDESCEX")]
    public PARAMDESCEX* pparamdescex;

    /// <include file='PARAMDESC.xml' path='doc/member[@name="PARAMDESC.wParamFlags"]/*' />
    public ushort wParamFlags;
}
