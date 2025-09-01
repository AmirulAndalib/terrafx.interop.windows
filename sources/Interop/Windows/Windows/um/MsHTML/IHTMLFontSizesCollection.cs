// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLFontSizesCollection.xml' path='doc/member[@name="IHTMLFontSizesCollection"]/*' />
[Guid("3050F377-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLFontSizesCollection : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLFontSizesCollection : IHTMLFontSizesCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHTMLFontSizesCollection);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, uint>)(lpVtbl[1]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, uint>)(lpVtbl[2]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, uint*, int>)(lpVtbl[3]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLFontSizesCollection.xml' path='doc/member[@name="IHTMLFontSizesCollection.get_length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, int*, int>)(lpVtbl[7]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFontSizesCollection.xml' path='doc/member[@name="IHTMLFontSizesCollection.get__newEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get__newEnum(IUnknown** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, IUnknown**, int>)(lpVtbl[8]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFontSizesCollection.xml' path='doc/member[@name="IHTMLFontSizesCollection.get_forFont"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_forFont([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, char**, int>)(lpVtbl[9]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLFontSizesCollection.xml' path='doc/member[@name="IHTMLFontSizesCollection.item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT item([NativeTypeName("long")] int index, [NativeTypeName("long *")] int* plSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLFontSizesCollection*, int, int*, int>)(lpVtbl[10]))((IHTMLFontSizesCollection*)Unsafe.AsPointer(ref this), index, plSize);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_length([NativeTypeName("long *")] int* p);

        [VtblIndex(8)]
        HRESULT get__newEnum(IUnknown** p);

        [VtblIndex(9)]
        HRESULT get_forFont([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(10)]
        HRESULT item([NativeTypeName("long")] int index, [NativeTypeName("long *")] int* plSize);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown**, int> get__newEnum;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_forFont;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int*, int> item;
    }
}
