// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B286-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IConnectionPoint : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IConnectionPoint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IConnectionPoint*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IConnectionPoint*, uint>)(lpVtbl[1]))((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IConnectionPoint*, uint>)(lpVtbl[2]))((IConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
        {
            return ((delegate* unmanaged<IConnectionPoint*, Guid*, int>)(lpVtbl[3]))((IConnectionPoint*)Unsafe.AsPointer(ref this), pIID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetConnectionPointContainer(IConnectionPointContainer** ppCPC)
        {
            return ((delegate* unmanaged<IConnectionPoint*, IConnectionPointContainer**, int>)(lpVtbl[4]))((IConnectionPoint*)Unsafe.AsPointer(ref this), ppCPC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Advise(IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IConnectionPoint*, IUnknown*, uint*, int>)(lpVtbl[5]))((IConnectionPoint*)Unsafe.AsPointer(ref this), pUnkSink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IConnectionPoint*, uint, int>)(lpVtbl[6]))((IConnectionPoint*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EnumConnections(IEnumConnections** ppEnum)
        {
            return ((delegate* unmanaged<IConnectionPoint*, IEnumConnections**, int>)(lpVtbl[7]))((IConnectionPoint*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, uint> Release;

            [NativeTypeName("HRESULT (IID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, Guid*, int> GetConnectionInterface;

            [NativeTypeName("HRESULT (IConnectionPointContainer **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, IConnectionPointContainer**, int> GetConnectionPointContainer;

            [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, IUnknown*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPoint*, IEnumConnections**, int> EnumConnections;
        }
    }
}
