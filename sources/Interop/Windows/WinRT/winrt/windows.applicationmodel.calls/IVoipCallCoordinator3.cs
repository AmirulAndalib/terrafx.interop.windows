// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoipCallCoordinator3.xml' path='doc/member[@name="IVoipCallCoordinator3"]/*' />
[Guid("338D0CBF-9B55-4021-87CA-E64B9BD666C7")]
[NativeTypeName("struct IVoipCallCoordinator3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipCallCoordinator3 : IVoipCallCoordinator3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoipCallCoordinator3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, Guid*, void**, int>)(lpVtbl[0]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, uint>)(lpVtbl[1]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, uint>)(lpVtbl[2]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, uint*, Guid**, int>)(lpVtbl[3]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, HSTRING*, int>)(lpVtbl[4]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, TrustLevel*, int>)(lpVtbl[5]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoipCallCoordinator3.xml' path='doc/member[@name="IVoipCallCoordinator3.RequestNewAppInitiatedCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestNewAppInitiatedCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, HSTRING, HSTRING, HSTRING, HSTRING, VoipPhoneCallMedia, IVoipPhoneCall**, int>)(lpVtbl[6]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this), context, contactName, contactNumber, serviceName, media, call);
    }

    /// <include file='IVoipCallCoordinator3.xml' path='doc/member[@name="IVoipCallCoordinator3.RequestNewIncomingCallWithContactRemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestNewIncomingCallWithContactRemoteId(HSTRING context, HSTRING contactName, HSTRING contactNumber, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* contactImage, HSTRING serviceName, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* brandingImage, HSTRING callDetails, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* ringtone, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout, HSTRING contactRemoteId, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator3*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, VoipPhoneCallMedia, TimeSpan, HSTRING, IVoipPhoneCall**, int>)(lpVtbl[7]))((IVoipCallCoordinator3*)Unsafe.AsPointer(ref this), context, contactName, contactNumber, contactImage, serviceName, brandingImage, callDetails, ringtone, media, ringTimeout, contactRemoteId, call);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestNewAppInitiatedCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call);

        [VtblIndex(7)]
        HRESULT RequestNewIncomingCallWithContactRemoteId(HSTRING context, HSTRING contactName, HSTRING contactNumber, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* contactImage, HSTRING serviceName, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* brandingImage, HSTRING callDetails, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* ringtone, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan ringTimeout, HSTRING contactRemoteId, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, HSTRING, VoipPhoneCallMedia, IVoipPhoneCall**, int> RequestNewAppInitiatedCall;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::Foundation::TimeSpan, HSTRING, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, HSTRING, IUriRuntimeClass*, VoipPhoneCallMedia, TimeSpan, HSTRING, IVoipPhoneCall**, int> RequestNewIncomingCallWithContactRemoteId;
    }
}
