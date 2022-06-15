// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISVGAnimatedAngle.xml' path='doc/member[@name="ISVGAnimatedAngle"]/*' />
[Guid("305104D4-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGAnimatedAngle : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGAnimatedAngle : ISVGAnimatedAngle.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ISVGAnimatedAngle;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, Guid*, void**, int>)(lpVtbl[0]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, uint>)(lpVtbl[1]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, uint>)(lpVtbl[2]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, uint*, int>)(lpVtbl[3]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGAnimatedAngle.xml' path='doc/member[@name="ISVGAnimatedAngle.putref_baseVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_baseVal(ISVGAngle* v)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, ISVGAngle*, int>)(lpVtbl[7]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAnimatedAngle.xml' path='doc/member[@name="ISVGAnimatedAngle.get_baseVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_baseVal(ISVGAngle** p)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, ISVGAngle**, int>)(lpVtbl[8]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGAnimatedAngle.xml' path='doc/member[@name="ISVGAnimatedAngle.putref_animVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_animVal(ISVGAngle* v)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, ISVGAngle*, int>)(lpVtbl[9]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGAnimatedAngle.xml' path='doc/member[@name="ISVGAnimatedAngle.get_animVal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_animVal(ISVGAngle** p)
    {
        return ((delegate* unmanaged<ISVGAnimatedAngle*, ISVGAngle**, int>)(lpVtbl[10]))((ISVGAnimatedAngle*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_baseVal(ISVGAngle* v);

        [VtblIndex(8)]
        HRESULT get_baseVal(ISVGAngle** p);

        [VtblIndex(9)]
        HRESULT putref_animVal(ISVGAngle* v);

        [VtblIndex(10)]
        HRESULT get_animVal(ISVGAngle** p);
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

        [NativeTypeName("HRESULT (ISVGAngle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAngle*, int> putref_baseVal;

        [NativeTypeName("HRESULT (ISVGAngle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAngle**, int> get_baseVal;

        [NativeTypeName("HRESULT (ISVGAngle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAngle*, int> putref_animVal;

        [NativeTypeName("HRESULT (ISVGAngle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAngle**, int> get_animVal;
    }
}
