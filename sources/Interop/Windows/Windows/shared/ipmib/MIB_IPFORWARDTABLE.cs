// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_IPFORWARDTABLE.xml' path='doc/member[@name="MIB_IPFORWARDTABLE"]/*' />
public partial struct MIB_IPFORWARDTABLE
{
    /// <include file='MIB_IPFORWARDTABLE.xml' path='doc/member[@name="MIB_IPFORWARDTABLE.dwNumEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;

    /// <include file='MIB_IPFORWARDTABLE.xml' path='doc/member[@name="MIB_IPFORWARDTABLE.table"]/*' />
    [NativeTypeName("MIB_IPFORWARDROW[1]")]
    public _table_e__FixedBuffer table;

    /// <include file='_table_e__FixedBuffer.xml' path='doc/member[@name="_table_e__FixedBuffer"]/*' />
    public partial struct _table_e__FixedBuffer
    {
        public MIB_IPFORWARDROW e0;

        [UnscopedRef]
        public ref MIB_IPFORWARDROW this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_IPFORWARDROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
