// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISVGFitToViewBox.xml' path='doc/member[@name="ISVGFitToViewBox"]/*' />
[Guid("305104E0-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGFitToViewBox : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGFitToViewBox : ISVGFitToViewBox.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGFitToViewBox));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, Guid*, void**, int>)(lpVtbl[0]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, uint>)(lpVtbl[1]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, uint>)(lpVtbl[2]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, uint*, int>)(lpVtbl[3]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGFitToViewBox.xml' path='doc/member[@name="ISVGFitToViewBox.get_viewBox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_viewBox(ISVGAnimatedRect** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, ISVGAnimatedRect**, int>)(lpVtbl[7]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGFitToViewBox.xml' path='doc/member[@name="ISVGFitToViewBox.putref_preserveAspectRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT putref_preserveAspectRatio(ISVGAnimatedPreserveAspectRatio* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, ISVGAnimatedPreserveAspectRatio*, int>)(lpVtbl[8]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGFitToViewBox.xml' path='doc/member[@name="ISVGFitToViewBox.get_preserveAspectRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_preserveAspectRatio(ISVGAnimatedPreserveAspectRatio** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGFitToViewBox*, ISVGAnimatedPreserveAspectRatio**, int>)(lpVtbl[9]))((ISVGFitToViewBox*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_viewBox(ISVGAnimatedRect** p);

        [VtblIndex(8)]
        HRESULT putref_preserveAspectRatio(ISVGAnimatedPreserveAspectRatio* v);

        [VtblIndex(9)]
        HRESULT get_preserveAspectRatio(ISVGAnimatedPreserveAspectRatio** p);
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

        [NativeTypeName("HRESULT (ISVGAnimatedRect **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedRect**, int> get_viewBox;

        [NativeTypeName("HRESULT (ISVGAnimatedPreserveAspectRatio *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedPreserveAspectRatio*, int> putref_preserveAspectRatio;

        [NativeTypeName("HRESULT (ISVGAnimatedPreserveAspectRatio **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedPreserveAspectRatio**, int> get_preserveAspectRatio;
    }
}
