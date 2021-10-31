// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F6696E82-74F7-4F3D-A178-8A5E09C3659F")]
    [NativeTypeName("struct IMFClockStateSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFClockStateSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFClockStateSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFClockStateSink*, uint>)(lpVtbl[1]))((IMFClockStateSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFClockStateSink*, uint>)(lpVtbl[2]))((IMFClockStateSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnClockStart([NativeTypeName("MFTIME")] long hnsSystemTime, [NativeTypeName("LONGLONG")] long llClockStartOffset)
        {
            return ((delegate* unmanaged<IMFClockStateSink*, long, long, int>)(lpVtbl[3]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime, llClockStartOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* unmanaged<IMFClockStateSink*, long, int>)(lpVtbl[4]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* unmanaged<IMFClockStateSink*, long, int>)(lpVtbl[5]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
        {
            return ((delegate* unmanaged<IMFClockStateSink*, long, int>)(lpVtbl[6]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
        {
            return ((delegate* unmanaged<IMFClockStateSink*, long, float, int>)(lpVtbl[7]))((IMFClockStateSink*)Unsafe.AsPointer(ref this), hnsSystemTime, flRate);
        }
    }
}
