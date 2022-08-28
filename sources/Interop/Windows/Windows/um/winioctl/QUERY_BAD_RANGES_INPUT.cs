// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='QUERY_BAD_RANGES_INPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_INPUT"]/*' />
public partial struct QUERY_BAD_RANGES_INPUT
{
    /// <include file='QUERY_BAD_RANGES_INPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='QUERY_BAD_RANGES_INPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_INPUT.NumRanges"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumRanges;

    /// <include file='QUERY_BAD_RANGES_INPUT.xml' path='doc/member[@name="QUERY_BAD_RANGES_INPUT.Ranges"]/*' />
    [NativeTypeName("QUERY_BAD_RANGES_INPUT_RANGE[1]")]
    public _Ranges_e__FixedBuffer Ranges;

    /// <include file='_Ranges_e__FixedBuffer.xml' path='doc/member[@name="_Ranges_e__FixedBuffer"]/*' />
    public partial struct _Ranges_e__FixedBuffer
    {
        public QUERY_BAD_RANGES_INPUT_RANGE e0;

        [UnscopedRef]
        public ref QUERY_BAD_RANGES_INPUT_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<QUERY_BAD_RANGES_INPUT_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
