// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct HIDP_DATA
    {
        [NativeTypeName("USHORT")]
        public ushort DataIndex;

        [NativeTypeName("USHORT")]
        public ushort Reserved;

        [NativeTypeName("_HIDP_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/hidpi.h:269:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint RawValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.RawValue, 1));
            }
        }

        public ref byte On
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.On, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint RawValue;

            [FieldOffset(0)]
            [NativeTypeName("BOOLEAN")]
            public byte On;
        }
    }
}
