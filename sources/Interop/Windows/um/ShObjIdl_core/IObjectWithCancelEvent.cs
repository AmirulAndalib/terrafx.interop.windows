// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F279B885-0AE9-4B85-AC06-DDECF9408941")]
    [NativeTypeName("struct IObjectWithCancelEvent : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IObjectWithCancelEvent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithCancelEvent*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithCancelEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithCancelEvent*, uint>)(lpVtbl[1]))((IObjectWithCancelEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithCancelEvent*, uint>)(lpVtbl[2]))((IObjectWithCancelEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCancelEvent(HANDLE* phEvent)
        {
            return ((delegate* unmanaged<IObjectWithCancelEvent*, HANDLE*, int>)(lpVtbl[3]))((IObjectWithCancelEvent*)Unsafe.AsPointer(ref this), phEvent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithCancelEvent*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithCancelEvent*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithCancelEvent*, uint> Release;

            [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithCancelEvent*, HANDLE*, int> GetCancelEvent;
        }
    }
}
