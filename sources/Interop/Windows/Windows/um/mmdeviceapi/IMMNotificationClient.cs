// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMMNotificationClient.xml' path='doc/member[@name="IMMNotificationClient"]/*' />
[Guid("7991EEC9-7E89-4D85-8390-6C703CEC60C0")]
[NativeTypeName("struct IMMNotificationClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMMNotificationClient : IMMNotificationClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMMNotificationClient));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, Guid*, void**, int>)(lpVtbl[0]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, uint>)(lpVtbl[1]))((IMMNotificationClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, uint>)(lpVtbl[2]))((IMMNotificationClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMMNotificationClient.xml' path='doc/member[@name="IMMNotificationClient.OnDeviceStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDeviceStateChanged([NativeTypeName("LPCWSTR")] char* pwstrDeviceId, [NativeTypeName("DWORD")] uint dwNewState)
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, char*, uint, int>)(lpVtbl[3]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId, dwNewState);
    }

    /// <include file='IMMNotificationClient.xml' path='doc/member[@name="IMMNotificationClient.OnDeviceAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnDeviceAdded([NativeTypeName("LPCWSTR")] char* pwstrDeviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, char*, int>)(lpVtbl[4]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId);
    }

    /// <include file='IMMNotificationClient.xml' path='doc/member[@name="IMMNotificationClient.OnDeviceRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnDeviceRemoved([NativeTypeName("LPCWSTR")] char* pwstrDeviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, char*, int>)(lpVtbl[5]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId);
    }

    /// <include file='IMMNotificationClient.xml' path='doc/member[@name="IMMNotificationClient.OnDefaultDeviceChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnDefaultDeviceChanged(EDataFlow flow, ERole role, [NativeTypeName("LPCWSTR")] char* pwstrDefaultDeviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, EDataFlow, ERole, char*, int>)(lpVtbl[6]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), flow, role, pwstrDefaultDeviceId);
    }

    /// <include file='IMMNotificationClient.xml' path='doc/member[@name="IMMNotificationClient.OnPropertyValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnPropertyValueChanged([NativeTypeName("LPCWSTR")] char* pwstrDeviceId, [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key)
    {
        return ((delegate* unmanaged[MemberFunction]<IMMNotificationClient*, char*, PROPERTYKEY, int>)(lpVtbl[7]))((IMMNotificationClient*)Unsafe.AsPointer(ref this), pwstrDeviceId, key);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDeviceStateChanged([NativeTypeName("LPCWSTR")] char* pwstrDeviceId, [NativeTypeName("DWORD")] uint dwNewState);

        [VtblIndex(4)]
        HRESULT OnDeviceAdded([NativeTypeName("LPCWSTR")] char* pwstrDeviceId);

        [VtblIndex(5)]
        HRESULT OnDeviceRemoved([NativeTypeName("LPCWSTR")] char* pwstrDeviceId);

        [VtblIndex(6)]
        HRESULT OnDefaultDeviceChanged(EDataFlow flow, ERole role, [NativeTypeName("LPCWSTR")] char* pwstrDefaultDeviceId);

        [VtblIndex(7)]
        HRESULT OnPropertyValueChanged([NativeTypeName("LPCWSTR")] char* pwstrDeviceId, [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key);
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

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> OnDeviceStateChanged;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> OnDeviceAdded;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> OnDeviceRemoved;

        [NativeTypeName("HRESULT (EDataFlow, ERole, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EDataFlow, ERole, char*, int> OnDefaultDeviceChanged;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPERTYKEY) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPERTYKEY, int> OnPropertyValueChanged;
    }
}
