// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHITEMID.xml' path='doc/member[@name="SHITEMID"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHITEMID
{
    /// <include file='SHITEMID.xml' path='doc/member[@name="SHITEMID.cb"]/*' />
    public ushort cb;

    /// <include file='SHITEMID.xml' path='doc/member[@name="SHITEMID.abID"]/*' />
    [NativeTypeName("BYTE [1]")]
    public fixed byte abID[1];
}
