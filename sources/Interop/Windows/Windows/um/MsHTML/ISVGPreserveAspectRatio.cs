// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISVGPreserveAspectRatio.xml' path='doc/member[@name="ISVGPreserveAspectRatio"]/*' />
[Guid("305104FA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGPreserveAspectRatio : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGPreserveAspectRatio : ISVGPreserveAspectRatio.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGPreserveAspectRatio));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, Guid*, void**, int>)(lpVtbl[0]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, uint>)(lpVtbl[1]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, uint>)(lpVtbl[2]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, uint*, int>)(lpVtbl[3]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGPreserveAspectRatio.xml' path='doc/member[@name="ISVGPreserveAspectRatio.put_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_align(short v)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, short, int>)(lpVtbl[7]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPreserveAspectRatio.xml' path='doc/member[@name="ISVGPreserveAspectRatio.get_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_align(short* p)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, short*, int>)(lpVtbl[8]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPreserveAspectRatio.xml' path='doc/member[@name="ISVGPreserveAspectRatio.put_meetOrSlice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_meetOrSlice(short v)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, short, int>)(lpVtbl[9]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPreserveAspectRatio.xml' path='doc/member[@name="ISVGPreserveAspectRatio.get_meetOrSlice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_meetOrSlice(short* p)
    {
        return ((delegate* unmanaged<ISVGPreserveAspectRatio*, short*, int>)(lpVtbl[10]))((ISVGPreserveAspectRatio*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_align(short v);

        [VtblIndex(8)]
        HRESULT get_align(short* p);

        [VtblIndex(9)]
        HRESULT put_meetOrSlice(short v);

        [VtblIndex(10)]
        HRESULT get_meetOrSlice(short* p);
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

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_align;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_align;

        [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_meetOrSlice;

        [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_meetOrSlice;
    }
}
