// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_EXCEPTION_INFORMATION.xml' path='doc/member[@name="SYSTEM_EXCEPTION_INFORMATION"]/*' />
public partial struct SYSTEM_EXCEPTION_INFORMATION
{
    /// <include file='SYSTEM_EXCEPTION_INFORMATION.xml' path='doc/member[@name="SYSTEM_EXCEPTION_INFORMATION.Reserved1"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
