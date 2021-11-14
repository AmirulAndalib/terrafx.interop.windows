// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("E56E4CBD-8F70-49D8-A0F8-EDB3D6AB9BF2")]
    [NativeTypeName("struct IMFTimer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimer : IMFTimer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimer*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimer*, uint>)(lpVtbl[1]))((IMFTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimer*, uint>)(lpVtbl[2]))((IMFTimer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetTimer([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONGLONG")] long llClockTime, IMFAsyncCallback* pCallback, IUnknown* punkState, IUnknown** ppunkKey)
        {
            return ((delegate* unmanaged<IMFTimer*, uint, long, IMFAsyncCallback*, IUnknown*, IUnknown**, int>)(lpVtbl[3]))((IMFTimer*)Unsafe.AsPointer(ref this), dwFlags, llClockTime, pCallback, punkState, ppunkKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CancelTimer(IUnknown* punkKey)
        {
            return ((delegate* unmanaged<IMFTimer*, IUnknown*, int>)(lpVtbl[4]))((IMFTimer*)Unsafe.AsPointer(ref this), punkKey);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetTimer([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONGLONG")] long llClockTime, IMFAsyncCallback* pCallback, IUnknown* punkState, IUnknown** ppunkKey);

            [VtblIndex(4)]
            HRESULT CancelTimer(IUnknown* punkKey);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimer*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LONGLONG, IMFAsyncCallback *, IUnknown *, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimer*, uint, long, IMFAsyncCallback*, IUnknown*, IUnknown**, int> SetTimer;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTimer*, IUnknown*, int> CancelTimer;
        }
    }
}
