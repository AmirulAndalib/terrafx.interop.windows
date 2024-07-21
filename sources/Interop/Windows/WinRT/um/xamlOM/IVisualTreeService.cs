// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService"]/*' />
[Guid("A593B11A-D17F-48BB-8F66-83910731C8A5")]
[NativeTypeName("struct IVisualTreeService : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IVisualTreeService : IVisualTreeService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualTreeService));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, uint>)(lpVtbl[1]))((IVisualTreeService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, uint>)(lpVtbl[2]))((IVisualTreeService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.AdviseVisualTreeChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, IVisualTreeServiceCallback*, int>)(lpVtbl[3]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCallback);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.UnadviseVisualTreeChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, IVisualTreeServiceCallback*, int>)(lpVtbl[4]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCallback);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.GetEnums"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, uint*, EnumType**, int>)(lpVtbl[5]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCount, ppEnums);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("BSTR")] char* typeName, [NativeTypeName("BSTR")] char* value, InstanceHandle* pInstanceHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, char*, char*, InstanceHandle*, int>)(lpVtbl[6]))((IVisualTreeService*)Unsafe.AsPointer(ref this), typeName, value, pInstanceHandle);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.GetPropertyValuesChain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyValuesChain(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, PropertyChainValue** ppPropertyValues)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int>)(lpVtbl[7]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.SetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetProperty(InstanceHandle instanceHandle, InstanceHandle value, [NativeTypeName("unsigned int")] uint propertyIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, InstanceHandle, uint, int>)(lpVtbl[8]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, value, propertyIndex);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.ClearProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearProperty(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, uint, int>)(lpVtbl[9]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, propertyIndex);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.GetCollectionCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCollectionCount(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, uint*, int>)(lpVtbl[10]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, pCollectionSize);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.GetCollectionElements"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCollectionElements(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, CollectionElementValue** ppElementValues)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, uint, uint*, CollectionElementValue**, int>)(lpVtbl[11]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, startIndex, pElementCount, ppElementValues);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.AddChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddChild(InstanceHandle parent, InstanceHandle child, [NativeTypeName("unsigned int")] uint index)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, InstanceHandle, uint, int>)(lpVtbl[12]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent, child, index);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.RemoveChild"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RemoveChild(InstanceHandle parent, [NativeTypeName("unsigned int")] uint index)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, uint, int>)(lpVtbl[13]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent, index);
    }

    /// <include file='IVisualTreeService.xml' path='doc/member[@name="IVisualTreeService.ClearChildren"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ClearChildren(InstanceHandle parent)
    {
        return ((delegate* unmanaged[MemberFunction]<IVisualTreeService*, InstanceHandle, int>)(lpVtbl[14]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseVisualTreeChange(IVisualTreeServiceCallback* pCallback);

        [VtblIndex(4)]
        HRESULT UnadviseVisualTreeChange(IVisualTreeServiceCallback* pCallback);

        [VtblIndex(5)]
        HRESULT GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums);

        [VtblIndex(6)]
        HRESULT CreateInstance([NativeTypeName("BSTR")] char* typeName, [NativeTypeName("BSTR")] char* value, InstanceHandle* pInstanceHandle);

        [VtblIndex(7)]
        HRESULT GetPropertyValuesChain(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, PropertyChainValue** ppPropertyValues);

        [VtblIndex(8)]
        HRESULT SetProperty(InstanceHandle instanceHandle, InstanceHandle value, [NativeTypeName("unsigned int")] uint propertyIndex);

        [VtblIndex(9)]
        HRESULT ClearProperty(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex);

        [VtblIndex(10)]
        HRESULT GetCollectionCount(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize);

        [VtblIndex(11)]
        HRESULT GetCollectionElements(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, CollectionElementValue** ppElementValues);

        [VtblIndex(12)]
        HRESULT AddChild(InstanceHandle parent, InstanceHandle child, [NativeTypeName("unsigned int")] uint index);

        [VtblIndex(13)]
        HRESULT RemoveChild(InstanceHandle parent, [NativeTypeName("unsigned int")] uint index);

        [VtblIndex(14)]
        HRESULT ClearChildren(InstanceHandle parent);
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

        [NativeTypeName("HRESULT (IVisualTreeServiceCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisualTreeServiceCallback*, int> AdviseVisualTreeChange;

        [NativeTypeName("HRESULT (IVisualTreeServiceCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVisualTreeServiceCallback*, int> UnadviseVisualTreeChange;

        [NativeTypeName("HRESULT (unsigned int *, EnumType **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, EnumType**, int> GetEnums;

        [NativeTypeName("HRESULT (BSTR, BSTR, InstanceHandle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, InstanceHandle*, int> CreateInstance;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int *, PropertyChainSource **, unsigned int *, PropertyChainValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int> GetPropertyValuesChain;

        [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, InstanceHandle, uint, int> SetProperty;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, uint, int> ClearProperty;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, uint*, int> GetCollectionCount;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int, unsigned int *, CollectionElementValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, uint, uint*, CollectionElementValue**, int> GetCollectionElements;

        [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, InstanceHandle, uint, int> AddChild;

        [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, uint, int> RemoveChild;

        [NativeTypeName("HRESULT (InstanceHandle) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InstanceHandle, int> ClearChildren;
    }
}
