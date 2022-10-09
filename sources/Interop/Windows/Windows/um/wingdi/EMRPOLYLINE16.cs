// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EMRPOLYLINE16.xml' path='doc/member[@name="EMRPOLYLINE16"]/*' />
public partial struct EMRPOLYLINE16
{
    /// <include file='EMRPOLYLINE16.xml' path='doc/member[@name="EMRPOLYLINE16.emr"]/*' />
    public EMR emr;

    /// <include file='EMRPOLYLINE16.xml' path='doc/member[@name="EMRPOLYLINE16.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRPOLYLINE16.xml' path='doc/member[@name="EMRPOLYLINE16.cpts"]/*' />
    [NativeTypeName("DWORD")]
    public uint cpts;

    /// <include file='EMRPOLYLINE16.xml' path='doc/member[@name="EMRPOLYLINE16.apts"]/*' />
    [NativeTypeName("POINTS[1]")]
    public _apts_e__FixedBuffer apts;

    /// <include file='_apts_e__FixedBuffer.xml' path='doc/member[@name="_apts_e__FixedBuffer"]/*' />
    public partial struct _apts_e__FixedBuffer
    {
        public POINTS e0;

        [UnscopedRef]
        public ref POINTS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
