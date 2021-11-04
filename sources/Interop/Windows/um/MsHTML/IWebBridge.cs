// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE24FDAD-03C6-11D1-8B76-0080C744F389")]
    [NativeTypeName("struct IWebBridge : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IWebBridge
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebBridge*, Guid*, void**, int>)(lpVtbl[0]))((IWebBridge*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebBridge*, uint>)(lpVtbl[1]))((IWebBridge*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebBridge*, uint>)(lpVtbl[2]))((IWebBridge*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IWebBridge*, uint*, int>)(lpVtbl[3]))((IWebBridge*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWebBridge*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebBridge*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWebBridge*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebBridge*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IWebBridge*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebBridge*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_URL([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IWebBridge*, ushort*, int>)(lpVtbl[7]))((IWebBridge*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IWebBridge*, ushort**, int>)(lpVtbl[8]))((IWebBridge*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_Scrollbar([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IWebBridge*, short, int>)(lpVtbl[9]))((IWebBridge*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_Scrollbar([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IWebBridge*, short*, int>)(lpVtbl[10]))((IWebBridge*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_embed([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IWebBridge*, short, int>)(lpVtbl[11]))((IWebBridge*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_embed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IWebBridge*, short*, int>)(lpVtbl[12]))((IWebBridge*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_event(IDispatch** p)
        {
            return ((delegate* unmanaged<IWebBridge*, IDispatch**, int>)(lpVtbl[13]))((IWebBridge*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_readyState([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IWebBridge*, int*, int>)(lpVtbl[14]))((IWebBridge*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT AboutBox()
        {
            return ((delegate* unmanaged<IWebBridge*, int>)(lpVtbl[15]))((IWebBridge*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, ushort*, int> put_URL;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, ushort**, int> get_URL;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, short, int> put_Scrollbar;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, short*, int> get_Scrollbar;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, short, int> put_embed;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, short*, int> get_embed;

            [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, IDispatch**, int> get_event;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, int*, int> get_readyState;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IWebBridge*, int> AboutBox;
        }
    }
}
