// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph"]/*' />
[Guid("56A8689F-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IFilterGraph : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFilterGraph : IFilterGraph.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFilterGraph*, Guid*, void**, int>)(lpVtbl[0]))((IFilterGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFilterGraph*, uint>)(lpVtbl[1]))((IFilterGraph*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFilterGraph*, uint>)(lpVtbl[2]))((IFilterGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.AddFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFilter(IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
    {
        return ((delegate* unmanaged<IFilterGraph*, IBaseFilter*, ushort*, int>)(lpVtbl[3]))((IFilterGraph*)Unsafe.AsPointer(ref this), pFilter, pName);
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.RemoveFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveFilter(IBaseFilter* pFilter)
    {
        return ((delegate* unmanaged<IFilterGraph*, IBaseFilter*, int>)(lpVtbl[4]))((IFilterGraph*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.EnumFilters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumFilters(IEnumFilters** ppEnum)
    {
        return ((delegate* unmanaged<IFilterGraph*, IEnumFilters**, int>)(lpVtbl[5]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.FindFilterByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged<IFilterGraph*, ushort*, IBaseFilter**, int>)(lpVtbl[6]))((IFilterGraph*)Unsafe.AsPointer(ref this), pName, ppFilter);
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.ConnectDirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectDirect(IPin* ppinOut, IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFilterGraph*, IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.Reconnect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reconnect(IPin* ppin)
    {
        return ((delegate* unmanaged<IFilterGraph*, IPin*, int>)(lpVtbl[8]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppin);
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.Disconnect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Disconnect(IPin* ppin)
    {
        return ((delegate* unmanaged<IFilterGraph*, IPin*, int>)(lpVtbl[9]))((IFilterGraph*)Unsafe.AsPointer(ref this), ppin);
    }

    /// <include file='IFilterGraph.xml' path='doc/member[@name="IFilterGraph.SetDefaultSyncSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDefaultSyncSource()
    {
        return ((delegate* unmanaged<IFilterGraph*, int>)(lpVtbl[10]))((IFilterGraph*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddFilter(IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName);

        [VtblIndex(4)]
        HRESULT RemoveFilter(IBaseFilter* pFilter);

        [VtblIndex(5)]
        HRESULT EnumFilters(IEnumFilters** ppEnum);

        [VtblIndex(6)]
        HRESULT FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, IBaseFilter** ppFilter);

        [VtblIndex(7)]
        HRESULT ConnectDirect(IPin* ppinOut, IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt);

        [VtblIndex(8)]
        HRESULT Reconnect(IPin* ppin);

        [VtblIndex(9)]
        HRESULT Disconnect(IPin* ppin);

        [VtblIndex(10)]
        HRESULT SetDefaultSyncSource();
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

        [NativeTypeName("HRESULT (IBaseFilter *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, ushort*, int> AddFilter;

        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, int> RemoveFilter;

        [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFilters**, int> EnumFilters;

        [NativeTypeName("HRESULT (LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IBaseFilter**, int> FindFilterByName;

        [NativeTypeName("HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, IPin*, AM_MEDIA_TYPE*, int> ConnectDirect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, int> Reconnect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, int> Disconnect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefaultSyncSource;
    }
}
