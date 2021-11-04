// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8389D2D0-77D7-11D1-ABE6-00A0C905F375")]
    [NativeTypeName("struct IAMResourceControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMResourceControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMResourceControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMResourceControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMResourceControl*, uint>)(lpVtbl[1]))((IAMResourceControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMResourceControl*, uint>)(lpVtbl[2]))((IAMResourceControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reserve([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pvReserved)
        {
            return ((delegate* unmanaged<IAMResourceControl*, uint, void*, int>)(lpVtbl[3]))((IAMResourceControl*)Unsafe.AsPointer(ref this), dwFlags, pvReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMResourceControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMResourceControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMResourceControl*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, PVOID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMResourceControl*, uint, void*, int> Reserve;
        }
    }
}
