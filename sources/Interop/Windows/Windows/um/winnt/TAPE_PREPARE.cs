// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TAPE_PREPARE.xml' path='doc/member[@name="TAPE_PREPARE"]/*' />
public partial struct TAPE_PREPARE
{
    /// <include file='TAPE_PREPARE.xml' path='doc/member[@name="TAPE_PREPARE.Operation"]/*' />
    [NativeTypeName("DWORD")]
    public uint Operation;

    /// <include file='TAPE_PREPARE.xml' path='doc/member[@name="TAPE_PREPARE.Immediate"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Immediate;
}
