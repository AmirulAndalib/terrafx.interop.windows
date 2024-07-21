// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CASCODE.xml' path='doc/member[@name="CASCODE"]/*' />
public unsafe partial struct CASCODE
{
    /// <include file='CASCODE.xml' path='doc/member[@name="CASCODE.cElems"]/*' />
    [NativeTypeName("ULONG")]
    public uint cElems;

    /// <include file='CASCODE.xml' path='doc/member[@name="CASCODE.pElems"]/*' />
    [NativeTypeName("SCODE *")]
    public int* pElems;
}
