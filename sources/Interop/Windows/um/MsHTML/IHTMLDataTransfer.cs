// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F4B3-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDataTransfer : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDataTransfer : IHTMLDataTransfer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, uint>)(lpVtbl[1]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, uint>)(lpVtbl[2]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, uint*, int>)(lpVtbl[3]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT setData([NativeTypeName("BSTR")] ushort* format, VARIANT* data, [NativeTypeName("VARIANT_BOOL *")] short* pret)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, ushort*, VARIANT*, short*, int>)(lpVtbl[7]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), format, data, pret);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT getData([NativeTypeName("BSTR")] ushort* format, VARIANT* pvarRet)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, ushort*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), format, pvarRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT clearData([NativeTypeName("BSTR")] ushort* format, [NativeTypeName("VARIANT_BOOL *")] short* pret)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, ushort*, short*, int>)(lpVtbl[9]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), format, pret);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_dropEffect([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, ushort*, int>)(lpVtbl[10]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_dropEffect([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, ushort**, int>)(lpVtbl[11]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_effectAllowed([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, ushort*, int>)(lpVtbl[12]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_effectAllowed([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDataTransfer*, ushort**, int>)(lpVtbl[13]))((IHTMLDataTransfer*)Unsafe.AsPointer(ref this), p);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT setData([NativeTypeName("BSTR")] ushort* format, VARIANT* data, [NativeTypeName("VARIANT_BOOL *")] short* pret);

            [VtblIndex(8)]
            HRESULT getData([NativeTypeName("BSTR")] ushort* format, VARIANT* pvarRet);

            [VtblIndex(9)]
            HRESULT clearData([NativeTypeName("BSTR")] ushort* format, [NativeTypeName("VARIANT_BOOL *")] short* pret);

            [VtblIndex(10)]
            HRESULT put_dropEffect([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(11)]
            HRESULT get_dropEffect([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(12)]
            HRESULT put_effectAllowed([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(13)]
            HRESULT get_effectAllowed([NativeTypeName("BSTR *")] ushort** p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, ushort*, VARIANT*, short*, int> setData;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, ushort*, VARIANT*, int> getData;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, ushort*, short*, int> clearData;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, ushort*, int> put_dropEffect;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, ushort**, int> get_dropEffect;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, ushort*, int> put_effectAllowed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDataTransfer*, ushort**, int> get_effectAllowed;
        }
    }
}
