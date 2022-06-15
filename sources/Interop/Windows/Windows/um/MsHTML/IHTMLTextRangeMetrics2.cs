// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLTextRangeMetrics2.xml' path='doc/member[@name="IHTMLTextRangeMetrics2"]/*' />
[Guid("3050F4A6-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTextRangeMetrics2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTextRangeMetrics2 : IHTMLTextRangeMetrics2.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IHTMLTextRangeMetrics2;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, uint>)(lpVtbl[1]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, uint>)(lpVtbl[2]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, uint*, int>)(lpVtbl[3]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTextRangeMetrics2.xml' path='doc/member[@name="IHTMLTextRangeMetrics2.getClientRects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getClientRects(IHTMLRectCollection** pRectCol)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, IHTMLRectCollection**, int>)(lpVtbl[7]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this), pRectCol);
    }

    /// <include file='IHTMLTextRangeMetrics2.xml' path='doc/member[@name="IHTMLTextRangeMetrics2.getBoundingClientRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT getBoundingClientRect(IHTMLRect** pRect)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics2*, IHTMLRect**, int>)(lpVtbl[8]))((IHTMLTextRangeMetrics2*)Unsafe.AsPointer(ref this), pRect);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT getClientRects(IHTMLRectCollection** pRectCol);

        [VtblIndex(8)]
        HRESULT getBoundingClientRect(IHTMLRect** pRect);
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

        [NativeTypeName("HRESULT (IHTMLRectCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLRectCollection**, int> getClientRects;

        [NativeTypeName("HRESULT (IHTMLRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLRect**, int> getBoundingClientRect;
    }
}
