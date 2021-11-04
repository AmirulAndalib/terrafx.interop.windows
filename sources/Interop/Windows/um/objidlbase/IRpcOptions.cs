// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000144-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IRpcOptions : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRpcOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcOptions*, Guid*, void**, int>)(lpVtbl[0]))((IRpcOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcOptions*, uint>)(lpVtbl[1]))((IRpcOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcOptions*, uint>)(lpVtbl[2]))((IRpcOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Set(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
        {
            return ((delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint, int>)(lpVtbl[3]))((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Query(IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue)
        {
            return ((delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint*, int>)(lpVtbl[4]))((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, pdwValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcOptions*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcOptions*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcOptions*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint, int> Set;

            [NativeTypeName("HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint*, int> Query;
        }
    }
}
