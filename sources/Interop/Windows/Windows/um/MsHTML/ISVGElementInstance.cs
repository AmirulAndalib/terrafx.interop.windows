// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance"]/*' />
[Guid("305104EE-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGElementInstance : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGElementInstance : ISVGElementInstance.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, Guid*, void**, int>)(lpVtbl[0]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGElementInstance*, uint>)(lpVtbl[1]))((ISVGElementInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGElementInstance*, uint>)(lpVtbl[2]))((ISVGElementInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, uint*, int>)(lpVtbl[3]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_correspondingElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_correspondingElement(ISVGElement** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGElement**, int>)(lpVtbl[7]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_correspondingUseElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_correspondingUseElement(ISVGUseElement** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGUseElement**, int>)(lpVtbl[8]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_parentNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_parentNode(ISVGElementInstance** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGElementInstance**, int>)(lpVtbl[9]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_childNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_childNodes(ISVGElementInstanceList** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGElementInstanceList**, int>)(lpVtbl[10]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_firstChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_firstChild(ISVGElementInstance** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGElementInstance**, int>)(lpVtbl[11]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_lastChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_lastChild(ISVGElementInstance** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGElementInstance**, int>)(lpVtbl[12]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_previousSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_previousSibling(ISVGElementInstance** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGElementInstance**, int>)(lpVtbl[13]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGElementInstance.xml' path='doc/member[@name="ISVGElementInstance.get_nextSibling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_nextSibling(ISVGElementInstance** p)
    {
        return ((delegate* unmanaged<ISVGElementInstance*, ISVGElementInstance**, int>)(lpVtbl[14]))((ISVGElementInstance*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_correspondingElement(ISVGElement** p);

        [VtblIndex(8)]
        HRESULT get_correspondingUseElement(ISVGUseElement** p);

        [VtblIndex(9)]
        HRESULT get_parentNode(ISVGElementInstance** p);

        [VtblIndex(10)]
        HRESULT get_childNodes(ISVGElementInstanceList** p);

        [VtblIndex(11)]
        HRESULT get_firstChild(ISVGElementInstance** p);

        [VtblIndex(12)]
        HRESULT get_lastChild(ISVGElementInstance** p);

        [VtblIndex(13)]
        HRESULT get_previousSibling(ISVGElementInstance** p);

        [VtblIndex(14)]
        HRESULT get_nextSibling(ISVGElementInstance** p);
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

        [NativeTypeName("HRESULT (ISVGElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElement**, int> get_correspondingElement;

        [NativeTypeName("HRESULT (ISVGUseElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGUseElement**, int> get_correspondingUseElement;

        [NativeTypeName("HRESULT (ISVGElementInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance**, int> get_parentNode;

        [NativeTypeName("HRESULT (ISVGElementInstanceList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstanceList**, int> get_childNodes;

        [NativeTypeName("HRESULT (ISVGElementInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance**, int> get_firstChild;

        [NativeTypeName("HRESULT (ISVGElementInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance**, int> get_lastChild;

        [NativeTypeName("HRESULT (ISVGElementInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance**, int> get_previousSibling;

        [NativeTypeName("HRESULT (ISVGElementInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElementInstance**, int> get_nextSibling;
    }
}
