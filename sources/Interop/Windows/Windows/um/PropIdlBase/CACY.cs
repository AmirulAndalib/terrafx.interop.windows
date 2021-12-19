// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CACY.xml' path='doc/member[@name="CACY"]/*' />
public unsafe partial struct CACY
{
    /// <include file='CACY.xml' path='doc/member[@name="CACY.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CACY.xml' path='doc/member[@name="CACY.pElems"]/*' />
    public CY* pElems;
}
