// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct PPM_IDLE_ACCOUNTING_EX
    {
        [NativeTypeName("DWORD")]
        public uint StateCount;

        [NativeTypeName("DWORD")]
        public uint TotalTransitions;

        [NativeTypeName("DWORD")]
        public uint ResetCount;

        [NativeTypeName("DWORD")]
        public uint AbortCount;

        [NativeTypeName("DWORD64")]
        public ulong StartTime;

        [NativeTypeName("PPM_IDLE_STATE_ACCOUNTING_EX [1]")]
        public _State_e__FixedBuffer State;

        public partial struct _State_e__FixedBuffer
        {
            public PPM_IDLE_STATE_ACCOUNTING_EX e0;

            public ref PPM_IDLE_STATE_ACCOUNTING_EX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PPM_IDLE_STATE_ACCOUNTING_EX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}