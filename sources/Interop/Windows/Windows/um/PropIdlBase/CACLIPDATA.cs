// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CACLIPDATA.xml' path='doc/member[@name="CACLIPDATA"]/*' />
public unsafe partial struct CACLIPDATA
{
    /// <include file='CACLIPDATA.xml' path='doc/member[@name="CACLIPDATA.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CACLIPDATA.xml' path='doc/member[@name="CACLIPDATA.pElems"]/*' />
    public CLIPDATA* pElems;
}
