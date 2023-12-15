// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLA
{
    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.dwControlID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlID;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.dwControlType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlType;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.fdwControl"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwControl;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.cMultipleItems"]/*' />
    [NativeTypeName("DWORD")]
    public uint cMultipleItems;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.szShortName"]/*' />
    [NativeTypeName("CHAR[16]")]
    public _szShortName_e__FixedBuffer szShortName;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.szName"]/*' />
    [NativeTypeName("CHAR[64]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.Bounds"]/*' />
    [NativeTypeName("__AnonymousRecord_mmeapi_L2056_C5")]
    public _Bounds_e__Union Bounds;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.Metrics"]/*' />
    [NativeTypeName("__AnonymousRecord_mmeapi_L2067_C5")]
    public _Metrics_e__Union Metrics;

    /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Bounds_e__Union
    {
        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.Anonymous1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmeapi_L2057_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.Anonymous2"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_mmeapi_L2061_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.dwReserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public _dwReserved_e__FixedBuffer dwReserved;

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMinimum"]/*' />
        [UnscopedRef]
        public ref int lMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.lMinimum;
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMaximum"]/*' />
        [UnscopedRef]
        public ref int lMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.lMaximum;
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMinimum"]/*' />
        [UnscopedRef]
        public ref uint dwMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dwMinimum;
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMaximum"]/*' />
        [UnscopedRef]
        public ref uint dwMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dwMaximum;
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMinimum"]/*' />
            [NativeTypeName("LONG")]
            public int lMinimum;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMaximum"]/*' />
            [NativeTypeName("LONG")]
            public int lMaximum;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMinimum"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwMinimum;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMaximum"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwMaximum;
        }

        /// <include file='_dwReserved_e__FixedBuffer.xml' path='doc/member[@name="_dwReserved_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [InlineArray(6)]
        public partial struct _dwReserved_e__FixedBuffer
        {
            public uint e0;
        }
    }

    /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Metrics_e__Union
    {
        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.cSteps"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cSteps;

        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.cbCustomData"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbCustomData;

        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.dwReserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public _dwReserved_e__FixedBuffer dwReserved;

        /// <include file='_dwReserved_e__FixedBuffer.xml' path='doc/member[@name="_dwReserved_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [InlineArray(6)]
        public partial struct _dwReserved_e__FixedBuffer
        {
            public uint e0;
        }
    }

    /// <include file='_szShortName_e__FixedBuffer.xml' path='doc/member[@name="_szShortName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szShortName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
