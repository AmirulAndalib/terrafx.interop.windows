// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT"]/*' />
public partial struct ARM64_NT_CONTEXT
{
    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.ContextFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ContextFlags;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Cpsr"]/*' />
    [NativeTypeName("DWORD")]
    public uint Cpsr;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L6812_C18")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Sp"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Sp;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Pc"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Pc;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.V"]/*' />
    [NativeTypeName("ARM64_NT_NEON128[32]")]
    public _V_e__FixedBuffer V;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Fpcr"]/*' />
    [NativeTypeName("DWORD")]
    public uint Fpcr;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Fpsr"]/*' />
    [NativeTypeName("DWORD")]
    public uint Fpsr;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Bcr"]/*' />
    [NativeTypeName("DWORD[8]")]
    public _Bcr_e__FixedBuffer Bcr;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Bvr"]/*' />
    [NativeTypeName("DWORD64[8]")]
    public _Bvr_e__FixedBuffer Bvr;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Wcr"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _Wcr_e__FixedBuffer Wcr;

    /// <include file='ARM64_NT_CONTEXT.xml' path='doc/member[@name="ARM64_NT_CONTEXT.Wvr"]/*' />
    [NativeTypeName("DWORD64[2]")]
    public _Wvr_e__FixedBuffer Wvr;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X0"]/*' />
    [UnscopedRef]
    public ref ulong X0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X0;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X1"]/*' />
    [UnscopedRef]
    public ref ulong X1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X1;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X2"]/*' />
    [UnscopedRef]
    public ref ulong X2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X2;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X3"]/*' />
    [UnscopedRef]
    public ref ulong X3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X3;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X4"]/*' />
    [UnscopedRef]
    public ref ulong X4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X4;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X5"]/*' />
    [UnscopedRef]
    public ref ulong X5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X5;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X6"]/*' />
    [UnscopedRef]
    public ref ulong X6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X6;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X7"]/*' />
    [UnscopedRef]
    public ref ulong X7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X7;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X8"]/*' />
    [UnscopedRef]
    public ref ulong X8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X8;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X9"]/*' />
    [UnscopedRef]
    public ref ulong X9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X9;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X10"]/*' />
    [UnscopedRef]
    public ref ulong X10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X10;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X11"]/*' />
    [UnscopedRef]
    public ref ulong X11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X11;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X12"]/*' />
    [UnscopedRef]
    public ref ulong X12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X12;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X13"]/*' />
    [UnscopedRef]
    public ref ulong X13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X13;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X14"]/*' />
    [UnscopedRef]
    public ref ulong X14
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X14;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X15"]/*' />
    [UnscopedRef]
    public ref ulong X15
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X15;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X16"]/*' />
    [UnscopedRef]
    public ref ulong X16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X16;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X17"]/*' />
    [UnscopedRef]
    public ref ulong X17
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X17;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X18"]/*' />
    [UnscopedRef]
    public ref ulong X18
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X18;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X19"]/*' />
    [UnscopedRef]
    public ref ulong X19
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X19;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X20"]/*' />
    [UnscopedRef]
    public ref ulong X20
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X20;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X21"]/*' />
    [UnscopedRef]
    public ref ulong X21
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X21;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X22"]/*' />
    [UnscopedRef]
    public ref ulong X22
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X22;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X23"]/*' />
    [UnscopedRef]
    public ref ulong X23
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X23;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X24"]/*' />
    [UnscopedRef]
    public ref ulong X24
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X24;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X25"]/*' />
    [UnscopedRef]
    public ref ulong X25
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X25;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X26"]/*' />
    [UnscopedRef]
    public ref ulong X26
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X26;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X27"]/*' />
    [UnscopedRef]
    public ref ulong X27
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X27;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X28"]/*' />
    [UnscopedRef]
    public ref ulong X28
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.X28;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Fp"]/*' />
    [UnscopedRef]
    public ref ulong Fp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Fp;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lr"]/*' />
    [UnscopedRef]
    public ref ulong Lr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.Lr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.X"]/*' />
    [UnscopedRef]
    public Span<ulong> X
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.X;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L6813_C21")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.X"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD64[31]")]
        public _X_e__FixedBuffer X;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X0"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X0;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X1"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X1;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X2"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X2;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X3"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X3;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X4"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X4;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X5"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X5;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X6"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X6;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X7"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X7;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X8"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X8;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X9"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X9;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X10"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X10;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X11"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X11;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X12"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X12;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X13"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X13;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X14"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X14;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X15"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X15;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X16"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X16;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X17"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X17;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X18"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X18;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X19"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X19;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X20"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X20;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X21"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X21;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X22"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X22;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X23"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X23;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X24"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X24;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X25"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X25;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X26"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X26;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X27"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X27;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.X28"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong X28;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Fp"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong Fp;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lr"]/*' />
            [NativeTypeName("DWORD64")]
            public ulong Lr;
        }

        /// <include file='_X_e__FixedBuffer.xml' path='doc/member[@name="_X_e__FixedBuffer"]/*' />
        [InlineArray(31)]
        public partial struct _X_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    /// <include file='_V_e__FixedBuffer.xml' path='doc/member[@name="_V_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _V_e__FixedBuffer
    {
        public ARM64_NT_NEON128 e0;
    }

    /// <include file='_Bcr_e__FixedBuffer.xml' path='doc/member[@name="_Bcr_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Bcr_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_Bvr_e__FixedBuffer.xml' path='doc/member[@name="_Bvr_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Bvr_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_Wcr_e__FixedBuffer.xml' path='doc/member[@name="_Wcr_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Wcr_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_Wvr_e__FixedBuffer.xml' path='doc/member[@name="_Wvr_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Wvr_e__FixedBuffer
    {
        public ulong e0;
    }
}
