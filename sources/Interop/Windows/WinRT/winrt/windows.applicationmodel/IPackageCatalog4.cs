// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPackageCatalog4.xml' path='doc/member[@name="IPackageCatalog4"]/*' />
[Guid("C37C399B-44CC-4B7B-8BAF-796C04EAD3B9")]
[NativeTypeName("struct IPackageCatalog4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageCatalog4 : IPackageCatalog4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageCatalog4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, Guid*, void**, int>)(lpVtbl[0]))((IPackageCatalog4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, uint>)(lpVtbl[1]))((IPackageCatalog4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, uint>)(lpVtbl[2]))((IPackageCatalog4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, uint*, Guid**, int>)(lpVtbl[3]))((IPackageCatalog4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, HSTRING*, int>)(lpVtbl[4]))((IPackageCatalog4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, TrustLevel*, int>)(lpVtbl[5]))((IPackageCatalog4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPackageCatalog4.xml' path='doc/member[@name="IPackageCatalog4.AddResourcePackageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddResourcePackageAsync(HSTRING resourcePackageFamilyName, HSTRING resourceID, [NativeTypeName("ABI::Windows::ApplicationModel::AddResourcePackageOptions")] AddResourcePackageOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CApplicationModel__CPackageCatalogAddResourcePackageResult_Windows__CApplicationModel__CPackageInstallProgress_t **")] IAsyncOperationWithProgress<Pointer<IPackageCatalogAddResourcePackageResult>, PackageInstallProgress>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, HSTRING, HSTRING, AddResourcePackageOptions, IAsyncOperationWithProgress<Pointer<IPackageCatalogAddResourcePackageResult>, PackageInstallProgress>**, int>)(lpVtbl[6]))((IPackageCatalog4*)Unsafe.AsPointer(ref this), resourcePackageFamilyName, resourceID, options, operation);
    }

    /// <include file='IPackageCatalog4.xml' path='doc/member[@name="IPackageCatalog4.RemoveResourcePackagesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveResourcePackagesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CPackage_t *")] IIterable<Pointer<IPackage>>* resourcePackages, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageCatalogRemoveResourcePackagesResult_t **")] IAsyncOperation<Pointer<IPackageCatalogRemoveResourcePackagesResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPackageCatalog4*, IIterable<Pointer<IPackage>>*, IAsyncOperation<Pointer<IPackageCatalogRemoveResourcePackagesResult>>**, int>)(lpVtbl[7]))((IPackageCatalog4*)Unsafe.AsPointer(ref this), resourcePackages, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddResourcePackageAsync(HSTRING resourcePackageFamilyName, HSTRING resourceID, [NativeTypeName("ABI::Windows::ApplicationModel::AddResourcePackageOptions")] AddResourcePackageOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CApplicationModel__CPackageCatalogAddResourcePackageResult_Windows__CApplicationModel__CPackageInstallProgress_t **")] IAsyncOperationWithProgress<Pointer<IPackageCatalogAddResourcePackageResult>, PackageInstallProgress>** operation);

        [VtblIndex(7)]
        HRESULT RemoveResourcePackagesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CPackage_t *")] IIterable<Pointer<IPackage>>* resourcePackages, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageCatalogRemoveResourcePackagesResult_t **")] IAsyncOperation<Pointer<IPackageCatalogRemoveResourcePackagesResult>>** operation);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::AddResourcePackageOptions, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CApplicationModel__CPackageCatalogAddResourcePackageResult_Windows__CApplicationModel__CPackageInstallProgress_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, AddResourcePackageOptions, IAsyncOperationWithProgress<Pointer<IPackageCatalogAddResourcePackageResult>, PackageInstallProgress>**, int> AddResourcePackageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CPackage_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CPackageCatalogRemoveResourcePackagesResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IPackage>>*, IAsyncOperation<Pointer<IPackageCatalogRemoveResourcePackagesResult>>**, int> RemoveResourcePackagesAsync;
    }
}
