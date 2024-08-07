// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVibrationDeviceStatics.xml' path='doc/member[@name="IVibrationDeviceStatics"]/*' />
[Guid("53E2EDED-2290-4AC9-8EB3-1A84122EB71C")]
[NativeTypeName("struct IVibrationDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVibrationDeviceStatics : IVibrationDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVibrationDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, uint>)(lpVtbl[1]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, uint>)(lpVtbl[2]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVibrationDeviceStatics.xml' path='doc/member[@name="IVibrationDeviceStatics.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationAccessStatus_t **")] IAsyncOperation<VibrationAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, IAsyncOperation<VibrationAccessStatus>**, int>)(lpVtbl[6]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IVibrationDeviceStatics.xml' path='doc/member[@name="IVibrationDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, HSTRING*, int>)(lpVtbl[7]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IVibrationDeviceStatics.xml' path='doc/member[@name="IVibrationDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<Pointer<IVibrationDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, HSTRING, IAsyncOperation<Pointer<IVibrationDevice>>**, int>)(lpVtbl[8]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, operation);
    }

    /// <include file='IVibrationDeviceStatics.xml' path='doc/member[@name="IVibrationDeviceStatics.GetDefaultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<Pointer<IVibrationDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, IAsyncOperation<Pointer<IVibrationDevice>>**, int>)(lpVtbl[9]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IVibrationDeviceStatics.xml' path='doc/member[@name="IVibrationDeviceStatics.FindAllAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IVibrationDevice>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVibrationDeviceStatics*, IAsyncOperation<Pointer<IVectorView<Pointer<IVibrationDevice>>>>**, int>)(lpVtbl[10]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationAccessStatus_t **")] IAsyncOperation<VibrationAccessStatus>** operation);

        [VtblIndex(7)]
        HRESULT GetDeviceSelector(HSTRING* result);

        [VtblIndex(8)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<Pointer<IVibrationDevice>>** operation);

        [VtblIndex(9)]
        HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<Pointer<IVibrationDevice>>** operation);

        [VtblIndex(10)]
        HRESULT FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IVibrationDevice>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<VibrationAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IVibrationDevice>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVibrationDevice>>**, int> GetDefaultAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CHaptics__CVibrationDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IVibrationDevice>>>>**, int> FindAllAsync;
    }
}
