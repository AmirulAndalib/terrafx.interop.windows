// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SPPHRASEPROPERTY
    {
        [NativeTypeName("LPCWSTR")]
        public ushort* pszName;

        [NativeTypeName("SPPHRASEPROPERTY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/sapi.h:5475:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint ulId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ulId, 1));
            }
        }

        public ref byte bType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.bType, 1));
            }
        }

        public ref byte bReserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.bReserved, 1));
            }
        }

        public ref ushort usArrayIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.usArrayIndex, 1));
            }
        }

        [NativeTypeName("LPCWSTR")]
        public ushort* pszValue;

        public VARIANT vValue;

        [NativeTypeName("ULONG")]
        public uint ulFirstElement;

        [NativeTypeName("ULONG")]
        public uint ulCountOfElements;

        [NativeTypeName("const SPPHRASEPROPERTY *")]
        public SPPHRASEPROPERTY* pNextSibling;

        [NativeTypeName("const SPPHRASEPROPERTY *")]
        public SPPHRASEPROPERTY* pFirstChild;

        public float SREngineConfidence;

        [NativeTypeName("signed char")]
        public sbyte Confidence;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ulId;

            [FieldOffset(0)]
            [NativeTypeName("SPPHRASEPROPERTY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/sapi.h:5478:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public byte bType;

                public byte bReserved;

                [NativeTypeName("unsigned short")]
                public ushort usArrayIndex;
            }
        }
    }
}
