// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("30510444-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLParamElement2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLParamElement2 : IHTMLParamElement2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, uint>)(lpVtbl[1]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, uint>)(lpVtbl[2]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, uint*, int>)(lpVtbl[3]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort*, int>)(lpVtbl[7]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort**, int>)(lpVtbl[8]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort*, int>)(lpVtbl[9]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort**, int>)(lpVtbl[10]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_value([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort*, int>)(lpVtbl[11]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_value([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort**, int>)(lpVtbl[12]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_valueType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort*, int>)(lpVtbl[13]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_valueType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLParamElement2*, ushort**, int>)(lpVtbl[14]))((IHTMLParamElement2*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_type([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_value([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_value([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_valueType([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(14)]
        HRESULT get_valueType([NativeTypeName("BSTR *")] ushort** p);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_value;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_value;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_valueType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_valueType;
    }
}
