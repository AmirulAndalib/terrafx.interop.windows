// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("1F76A169-F994-40AC-8FC8-0959E8874710")]
[NativeTypeName("struct IApplicationAssociationRegistrationUI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationAssociationRegistrationUI : IApplicationAssociationRegistrationUI.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistrationUI*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistrationUI*, uint>)(lpVtbl[1]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistrationUI*, uint>)(lpVtbl[2]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LaunchAdvancedAssociationUI([NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName)
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistrationUI*, ushort*, int>)(lpVtbl[3]))((IApplicationAssociationRegistrationUI*)Unsafe.AsPointer(ref this), pszAppRegistryName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LaunchAdvancedAssociationUI([NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IApplicationAssociationRegistrationUI*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IApplicationAssociationRegistrationUI*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IApplicationAssociationRegistrationUI*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IApplicationAssociationRegistrationUI*, ushort*, int> LaunchAdvancedAssociationUI;
    }
}
