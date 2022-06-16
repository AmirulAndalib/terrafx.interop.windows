// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDOMMutationEvent.xml' path='doc/member[@name="IDOMMutationEvent"]/*' />
[Guid("305106DA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMMutationEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMMutationEvent : IDOMMutationEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMMutationEvent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, uint>)(lpVtbl[1]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, uint>)(lpVtbl[2]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, uint*, int>)(lpVtbl[3]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IDOMMutationEvent.xml' path='doc/member[@name="IDOMMutationEvent.get_relatedNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_relatedNode(IDispatch** p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, IDispatch**, int>)(lpVtbl[7]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMutationEvent.xml' path='doc/member[@name="IDOMMutationEvent.get_prevValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_prevValue([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, ushort**, int>)(lpVtbl[8]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMutationEvent.xml' path='doc/member[@name="IDOMMutationEvent.get_newValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_newValue([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, ushort**, int>)(lpVtbl[9]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMutationEvent.xml' path='doc/member[@name="IDOMMutationEvent.get_attrName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_attrName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, ushort**, int>)(lpVtbl[10]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMutationEvent.xml' path='doc/member[@name="IDOMMutationEvent.get_attrChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_attrChange(ushort* p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, ushort*, int>)(lpVtbl[11]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IDOMMutationEvent.xml' path='doc/member[@name="IDOMMutationEvent.initMutationEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT initMutationEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IDispatch* relatedNodeArg, [NativeTypeName("BSTR")] ushort* prevValueArg, [NativeTypeName("BSTR")] ushort* newValueArg, [NativeTypeName("BSTR")] ushort* attrNameArg, ushort attrChangeArg)
    {
        return ((delegate* unmanaged<IDOMMutationEvent*, ushort*, short, short, IDispatch*, ushort*, ushort*, ushort*, ushort, int>)(lpVtbl[12]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, relatedNodeArg, prevValueArg, newValueArg, attrNameArg, attrChangeArg);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_relatedNode(IDispatch** p);

        [VtblIndex(8)]
        HRESULT get_prevValue([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT get_newValue([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT get_attrName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT get_attrChange(ushort* p);

        [VtblIndex(12)]
        HRESULT initMutationEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IDispatch* relatedNodeArg, [NativeTypeName("BSTR")] ushort* prevValueArg, [NativeTypeName("BSTR")] ushort* newValueArg, [NativeTypeName("BSTR")] ushort* attrNameArg, ushort attrChangeArg);
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

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_relatedNode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_prevValue;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_newValue;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_attrName;

        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_attrChange;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, IDispatch *, BSTR, BSTR, BSTR, USHORT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, short, IDispatch*, ushort*, ushort*, ushort*, ushort, int> initMutationEvent;
    }
}
