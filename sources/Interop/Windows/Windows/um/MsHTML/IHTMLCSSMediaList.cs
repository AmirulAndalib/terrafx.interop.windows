// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLCSSMediaList.xml' path='doc/member[@name="IHTMLCSSMediaList"]/*' />
[Guid("30510731-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCSSMediaList : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCSSMediaList : IHTMLCSSMediaList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCSSMediaList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, uint>)(lpVtbl[1]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, uint>)(lpVtbl[2]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, uint*, int>)(lpVtbl[3]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLCSSMediaList.xml' path='doc/member[@name="IHTMLCSSMediaList.put_mediaText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_mediaText([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, ushort*, int>)(lpVtbl[7]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSMediaList.xml' path='doc/member[@name="IHTMLCSSMediaList.get_mediaText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_mediaText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, ushort**, int>)(lpVtbl[8]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSMediaList.xml' path='doc/member[@name="IHTMLCSSMediaList.get_length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, int*, int>)(lpVtbl[9]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSMediaList.xml' path='doc/member[@name="IHTMLCSSMediaList.item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT item([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** pbstrMedium)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, int, ushort**, int>)(lpVtbl[10]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), index, pbstrMedium);
    }

    /// <include file='IHTMLCSSMediaList.xml' path='doc/member[@name="IHTMLCSSMediaList.appendMedium"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT appendMedium([NativeTypeName("BSTR")] ushort* bstrMedium)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, ushort*, int>)(lpVtbl[11]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), bstrMedium);
    }

    /// <include file='IHTMLCSSMediaList.xml' path='doc/member[@name="IHTMLCSSMediaList.deleteMedium"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT deleteMedium([NativeTypeName("BSTR")] ushort* bstrMedium)
    {
        return ((delegate* unmanaged<IHTMLCSSMediaList*, ushort*, int>)(lpVtbl[12]))((IHTMLCSSMediaList*)Unsafe.AsPointer(ref this), bstrMedium);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_mediaText([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_mediaText([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT get_length([NativeTypeName("long *")] int* p);

        [VtblIndex(10)]
        HRESULT item([NativeTypeName("long")] int index, [NativeTypeName("BSTR *")] ushort** pbstrMedium);

        [VtblIndex(11)]
        HRESULT appendMedium([NativeTypeName("BSTR")] ushort* bstrMedium);

        [VtblIndex(12)]
        HRESULT deleteMedium([NativeTypeName("BSTR")] ushort* bstrMedium);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_mediaText;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_mediaText;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> item;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> appendMedium;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> deleteMedium;
    }
}
