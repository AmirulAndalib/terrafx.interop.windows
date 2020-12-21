// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct D2D_MATRIX_5X4_F
    {
        [NativeTypeName("D2D_MATRIX_5X4_F::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:373:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref float _11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._11, 1));
            }
        }

        public ref float _12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._12, 1));
            }
        }

        public ref float _13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._13, 1));
            }
        }

        public ref float _14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._14, 1));
            }
        }

        public ref float _21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._21, 1));
            }
        }

        public ref float _22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._22, 1));
            }
        }

        public ref float _23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._23, 1));
            }
        }

        public ref float _24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._24, 1));
            }
        }

        public ref float _31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._31, 1));
            }
        }

        public ref float _32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._32, 1));
            }
        }

        public ref float _33
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._33, 1));
            }
        }

        public ref float _34
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._34, 1));
            }
        }

        public ref float _41
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._41, 1));
            }
        }

        public ref float _42
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._42, 1));
            }
        }

        public ref float _43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._43, 1));
            }
        }

        public ref float _44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._44, 1));
            }
        }

        public ref float _51
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._51, 1));
            }
        }

        public ref float _52
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._52, 1));
            }
        }

        public ref float _53
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._53, 1));
            }
        }

        public ref float _54
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous._54, 1));
            }
        }

        public Span<float> m
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.m[0], 5);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("D2D_MATRIX_5X4_F::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:375:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT [5][4]")]
            public fixed float m[5 * 4];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("FLOAT")]
                public float _11;

                [NativeTypeName("FLOAT")]
                public float _12;

                [NativeTypeName("FLOAT")]
                public float _13;

                [NativeTypeName("FLOAT")]
                public float _14;

                [NativeTypeName("FLOAT")]
                public float _21;

                [NativeTypeName("FLOAT")]
                public float _22;

                [NativeTypeName("FLOAT")]
                public float _23;

                [NativeTypeName("FLOAT")]
                public float _24;

                [NativeTypeName("FLOAT")]
                public float _31;

                [NativeTypeName("FLOAT")]
                public float _32;

                [NativeTypeName("FLOAT")]
                public float _33;

                [NativeTypeName("FLOAT")]
                public float _34;

                [NativeTypeName("FLOAT")]
                public float _41;

                [NativeTypeName("FLOAT")]
                public float _42;

                [NativeTypeName("FLOAT")]
                public float _43;

                [NativeTypeName("FLOAT")]
                public float _44;

                [NativeTypeName("FLOAT")]
                public float _51;

                [NativeTypeName("FLOAT")]
                public float _52;

                [NativeTypeName("FLOAT")]
                public float _53;

                [NativeTypeName("FLOAT")]
                public float _54;
            }
        }
    }
}
