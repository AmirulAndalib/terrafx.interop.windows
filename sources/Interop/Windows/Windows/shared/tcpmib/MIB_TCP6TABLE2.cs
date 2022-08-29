// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_TCP6TABLE2.xml' path='doc/member[@name="MIB_TCP6TABLE2"]/*' />
public partial struct MIB_TCP6TABLE2
{
    /// <include file='MIB_TCP6TABLE2.xml' path='doc/member[@name="MIB_TCP6TABLE2.dwNumEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;

    /// <include file='MIB_TCP6TABLE2.xml' path='doc/member[@name="MIB_TCP6TABLE2.table"]/*' />
    [NativeTypeName("MIB_TCP6ROW2[1]")]
    public _table_e__FixedBuffer table;

    /// <include file='_table_e__FixedBuffer.xml' path='doc/member[@name="_table_e__FixedBuffer"]/*' />
    public partial struct _table_e__FixedBuffer
    {
        public MIB_TCP6ROW2 e0;

        [UnscopedRef]
        public ref MIB_TCP6ROW2 this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<MIB_TCP6ROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
