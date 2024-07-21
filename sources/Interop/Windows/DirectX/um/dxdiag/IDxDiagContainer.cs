// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDxDiagContainer.xml' path='doc/member[@name="IDxDiagContainer"]/*' />
[Guid("7D0F462F-4064-4862-BC7F-933E5058C10F")]
[NativeTypeName("struct IDxDiagContainer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxDiagContainer : IDxDiagContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxDiagContainer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, Guid*, void**, int>)(lpVtbl[0]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, uint>)(lpVtbl[1]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, uint>)(lpVtbl[2]))((IDxDiagContainer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxDiagContainer.xml' path='doc/member[@name="IDxDiagContainer.GetNumberOfChildContainers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, uint*, int>)(lpVtbl[3]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IDxDiagContainer.xml' path='doc/member[@name="IDxDiagContainer.EnumChildContainerNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumChildContainerNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pwszContainer, [NativeTypeName("DWORD")] uint cchContainer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, uint, char*, uint, int>)(lpVtbl[4]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszContainer, cchContainer);
    }

    /// <include file='IDxDiagContainer.xml' path='doc/member[@name="IDxDiagContainer.GetChildContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChildContainer([NativeTypeName("LPCWSTR")] char* pwszContainer, IDxDiagContainer** ppInstance)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, char*, IDxDiagContainer**, int>)(lpVtbl[5]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszContainer, ppInstance);
    }

    /// <include file='IDxDiagContainer.xml' path='doc/member[@name="IDxDiagContainer.GetNumberOfProps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, uint*, int>)(lpVtbl[6]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IDxDiagContainer.xml' path='doc/member[@name="IDxDiagContainer.EnumPropNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumPropNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pwszPropName, [NativeTypeName("DWORD")] uint cchPropName)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, uint, char*, uint, int>)(lpVtbl[7]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), dwIndex, pwszPropName, cchPropName);
    }

    /// <include file='IDxDiagContainer.xml' path='doc/member[@name="IDxDiagContainer.GetProp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProp([NativeTypeName("LPCWSTR")] char* pwszPropName, VARIANT* pvarProp)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxDiagContainer*, char*, VARIANT*, int>)(lpVtbl[8]))((IDxDiagContainer*)Unsafe.AsPointer(ref this), pwszPropName, pvarProp);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNumberOfChildContainers([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(4)]
        HRESULT EnumChildContainerNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pwszContainer, [NativeTypeName("DWORD")] uint cchContainer);

        [VtblIndex(5)]
        HRESULT GetChildContainer([NativeTypeName("LPCWSTR")] char* pwszContainer, IDxDiagContainer** ppInstance);

        [VtblIndex(6)]
        HRESULT GetNumberOfProps([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(7)]
        HRESULT EnumPropNames([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pwszPropName, [NativeTypeName("DWORD")] uint cchPropName);

        [VtblIndex(8)]
        HRESULT GetProp([NativeTypeName("LPCWSTR")] char* pwszPropName, VARIANT* pvarProp);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetNumberOfChildContainers;

        [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint, int> EnumChildContainerNames;

        [NativeTypeName("HRESULT (LPCWSTR, IDxDiagContainer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IDxDiagContainer**, int> GetChildContainer;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetNumberOfProps;

        [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint, int> EnumPropNames;

        [NativeTypeName("HRESULT (LPCWSTR, VARIANT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetProp;
    }
}
