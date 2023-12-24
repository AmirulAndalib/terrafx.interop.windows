// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION"]/*' />
public partial struct SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION
{
    /// <include file='SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.IdleTime"]/*' />
    public LARGE_INTEGER IdleTime;

    /// <include file='SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.KernelTime"]/*' />
    public LARGE_INTEGER KernelTime;

    /// <include file='SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.UserTime"]/*' />
    public LARGE_INTEGER UserTime;

    /// <include file='SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.Reserved1"]/*' />
    [NativeTypeName("LARGE_INTEGER[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.xml' path='doc/member[@name="SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION.Reserved2"]/*' />
    [NativeTypeName("ULONG")]
    public uint Reserved2;

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
    }
}
