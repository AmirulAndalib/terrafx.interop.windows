// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_UDPTABLE_OWNER_PID.xml' path='doc/member[@name="MIB_UDPTABLE_OWNER_PID"]/*' />
public partial struct MIB_UDPTABLE_OWNER_PID
{
    /// <include file='MIB_UDPTABLE_OWNER_PID.xml' path='doc/member[@name="MIB_UDPTABLE_OWNER_PID.dwNumEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;

    /// <include file='MIB_UDPTABLE_OWNER_PID.xml' path='doc/member[@name="MIB_UDPTABLE_OWNER_PID.table"]/*' />
    [NativeTypeName("MIB_UDPROW_OWNER_PID[1]")]
    public _table_e__FixedBuffer table;

    /// <include file='_table_e__FixedBuffer.xml' path='doc/member[@name="_table_e__FixedBuffer"]/*' />
    public partial struct _table_e__FixedBuffer
    {
        public MIB_UDPROW_OWNER_PID e0;

        [UnscopedRef]
        public ref MIB_UDPROW_OWNER_PID this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_UDPROW_OWNER_PID> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
