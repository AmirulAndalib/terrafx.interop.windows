// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPropertyDescriptionList.xml' path='doc/member[@name="IPropertyDescriptionList"]/*' />
[Guid("1F9FC1D0-C39B-4B26-817F-011967D3440E")]
[NativeTypeName("struct IPropertyDescriptionList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyDescriptionList : IPropertyDescriptionList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPropertyDescriptionList);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyDescriptionList*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyDescriptionList*, uint>)(lpVtbl[1]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyDescriptionList*, uint>)(lpVtbl[2]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyDescriptionList.xml' path='doc/member[@name="IPropertyDescriptionList.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pcElem)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyDescriptionList*, uint*, int>)(lpVtbl[3]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), pcElem);
    }

    /// <include file='IPropertyDescriptionList.xml' path='doc/member[@name="IPropertyDescriptionList.GetAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt(uint iElem, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IPropertyDescriptionList*, uint, Guid*, void**, int>)(lpVtbl[4]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), iElem, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(uint* pcElem);

        [VtblIndex(4)]
        HRESULT GetAt(uint iElem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, void**, int> GetAt;
    }
}
