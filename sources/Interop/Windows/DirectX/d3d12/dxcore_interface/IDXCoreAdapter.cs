// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter"]/*' />
[Guid("F0DB4C7F-FE5A-42A2-BD62-F2A6CF6FC83E")]
[NativeTypeName("struct IDXCoreAdapter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IDXCoreAdapter : IDXCoreAdapter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXCoreAdapter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, uint>)(lpVtbl[1]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, uint>)(lpVtbl[2]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsValid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool IsValid()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, bool>)(lpVtbl[3]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsAttributeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, Guid*, bool>)(lpVtbl[4]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), attributeGUID);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsPropertySupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsPropertySupported(DXCoreAdapterProperty property)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, DXCoreAdapterProperty, bool>)(lpVtbl[5]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, DXCoreAdapterProperty, nuint, void*, int>)(lpVtbl[6]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize, propertyData);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetPropertySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, DXCoreAdapterProperty, nuint*, int>)(lpVtbl[7]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property, bufferSize);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsQueryStateSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool IsQueryStateSupported(DXCoreAdapterState property)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, DXCoreAdapterState, bool>)(lpVtbl[8]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.QueryState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, DXCoreAdapterState, nuint, void*, nuint, void*, int>)(lpVtbl[9]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.IsSetStateSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsSetStateSupported(DXCoreAdapterState property)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, DXCoreAdapterState, bool>)(lpVtbl[10]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), property);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.SetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, DXCoreAdapterState, nuint, void*, nuint, void*, int>)(lpVtbl[11]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
    }

    /// <include file='IDXCoreAdapter.xml' path='doc/member[@name="IDXCoreAdapter.GetFactory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXCoreAdapter*, Guid*, void**, int>)(lpVtbl[12]))((IDXCoreAdapter*)Unsafe.AsPointer(ref this), riid, ppvFactory);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        bool IsValid();

        [VtblIndex(4)]
        bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID);

        [VtblIndex(5)]
        bool IsPropertySupported(DXCoreAdapterProperty property);

        [VtblIndex(6)]
        HRESULT GetProperty(DXCoreAdapterProperty property, [NativeTypeName("size_t")] nuint bufferSize, void* propertyData);

        [VtblIndex(7)]
        HRESULT GetPropertySize(DXCoreAdapterProperty property, [NativeTypeName("size_t *")] nuint* bufferSize);

        [VtblIndex(8)]
        bool IsQueryStateSupported(DXCoreAdapterState property);

        [VtblIndex(9)]
        HRESULT QueryState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint outputBufferSize, void* outputBuffer);

        [VtblIndex(10)]
        bool IsSetStateSupported(DXCoreAdapterState property);

        [VtblIndex(11)]
        HRESULT SetState(DXCoreAdapterState state, [NativeTypeName("size_t")] nuint inputStateDetailsSize, [NativeTypeName("const void *")] void* inputStateDetails, [NativeTypeName("size_t")] nuint inputDataSize, [NativeTypeName("const void *")] void* inputData);

        [VtblIndex(12)]
        HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
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

        [NativeTypeName("bool () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, bool> IsValid;

        [NativeTypeName("bool (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, bool> IsAttributeSupported;

        [NativeTypeName("bool (DXCoreAdapterProperty) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterProperty, bool> IsPropertySupported;

        [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterProperty, nuint, void*, int> GetProperty;

        [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterProperty, nuint*, int> GetPropertySize;

        [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, bool> IsQueryStateSupported;

        [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, nuint, void*, nuint, void*, int> QueryState;

        [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, bool> IsSetStateSupported;

        [NativeTypeName("HRESULT (DXCoreAdapterState, size_t, const void *, size_t, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DXCoreAdapterState, nuint, void*, nuint, void*, int> SetState;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetFactory;
    }
}
