// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement"]/*' />
[Guid("3051052C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGPatternElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGPatternElement : ISVGPatternElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGPatternElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, uint>)(lpVtbl[1]))((ISVGPatternElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, uint>)(lpVtbl[2]))((ISVGPatternElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, uint*, int>)(lpVtbl[3]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.putref_patternUnits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_patternUnits(ISVGAnimatedEnumeration* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[7]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.get_patternUnits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_patternUnits(ISVGAnimatedEnumeration** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[8]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.putref_patternContentUnits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_patternContentUnits(ISVGAnimatedEnumeration* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[9]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.get_patternContentUnits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_patternContentUnits(ISVGAnimatedEnumeration** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[10]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.putref_patternTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_patternTransform(ISVGAnimatedTransformList* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedTransformList*, int>)(lpVtbl[11]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.get_patternTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_patternTransform(ISVGAnimatedTransformList** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedTransformList**, int>)(lpVtbl[12]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.putref_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_x(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.get_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_x(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.putref_y"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT putref_y(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength*, int>)(lpVtbl[15]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.get_y"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_y(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength**, int>)(lpVtbl[16]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.putref_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT putref_width(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength*, int>)(lpVtbl[17]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.get_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_width(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength**, int>)(lpVtbl[18]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.putref_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT putref_height(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength*, int>)(lpVtbl[19]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGPatternElement.xml' path='doc/member[@name="ISVGPatternElement.get_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_height(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged[MemberFunction]<ISVGPatternElement*, ISVGAnimatedLength**, int>)(lpVtbl[20]))((ISVGPatternElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_patternUnits(ISVGAnimatedEnumeration* v);

        [VtblIndex(8)]
        HRESULT get_patternUnits(ISVGAnimatedEnumeration** p);

        [VtblIndex(9)]
        HRESULT putref_patternContentUnits(ISVGAnimatedEnumeration* v);

        [VtblIndex(10)]
        HRESULT get_patternContentUnits(ISVGAnimatedEnumeration** p);

        [VtblIndex(11)]
        HRESULT putref_patternTransform(ISVGAnimatedTransformList* v);

        [VtblIndex(12)]
        HRESULT get_patternTransform(ISVGAnimatedTransformList** p);

        [VtblIndex(13)]
        HRESULT putref_x(ISVGAnimatedLength* v);

        [VtblIndex(14)]
        HRESULT get_x(ISVGAnimatedLength** p);

        [VtblIndex(15)]
        HRESULT putref_y(ISVGAnimatedLength* v);

        [VtblIndex(16)]
        HRESULT get_y(ISVGAnimatedLength** p);

        [VtblIndex(17)]
        HRESULT putref_width(ISVGAnimatedLength* v);

        [VtblIndex(18)]
        HRESULT get_width(ISVGAnimatedLength** p);

        [VtblIndex(19)]
        HRESULT putref_height(ISVGAnimatedLength* v);

        [VtblIndex(20)]
        HRESULT get_height(ISVGAnimatedLength** p);
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

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedEnumeration*, int> putref_patternUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedEnumeration**, int> get_patternUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedEnumeration*, int> putref_patternContentUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedEnumeration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedEnumeration**, int> get_patternContentUnits;

        [NativeTypeName("HRESULT (ISVGAnimatedTransformList *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedTransformList*, int> putref_patternTransform;

        [NativeTypeName("HRESULT (ISVGAnimatedTransformList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedTransformList**, int> get_patternTransform;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength*, int> putref_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength**, int> get_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength*, int> putref_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength**, int> get_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength*, int> putref_width;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength**, int> get_width;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength*, int> putref_height;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISVGAnimatedLength**, int> get_height;
    }
}
