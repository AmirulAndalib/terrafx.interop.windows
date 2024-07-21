// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAMDeviceRemoval.xml' path='doc/member[@name="IAMDeviceRemoval"]/*' />
[Guid("F90A6130-B658-11D2-AE49-0000F8754B99")]
[NativeTypeName("struct IAMDeviceRemoval : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMDeviceRemoval : IAMDeviceRemoval.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMDeviceRemoval));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAMDeviceRemoval*, Guid*, void**, int>)(lpVtbl[0]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAMDeviceRemoval*, uint>)(lpVtbl[1]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAMDeviceRemoval*, uint>)(lpVtbl[2]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMDeviceRemoval.xml' path='doc/member[@name="IAMDeviceRemoval.DeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DeviceInfo([NativeTypeName("CLSID *")] Guid* pclsidInterfaceClass, [NativeTypeName("LPWSTR *")] char** pwszSymbolicLink)
    {
        return ((delegate* unmanaged[MemberFunction]<IAMDeviceRemoval*, Guid*, char**, int>)(lpVtbl[3]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this), pclsidInterfaceClass, pwszSymbolicLink);
    }

    /// <include file='IAMDeviceRemoval.xml' path='doc/member[@name="IAMDeviceRemoval.Reassociate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Reassociate()
    {
        return ((delegate* unmanaged[MemberFunction]<IAMDeviceRemoval*, int>)(lpVtbl[4]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMDeviceRemoval.xml' path='doc/member[@name="IAMDeviceRemoval.Disassociate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Disassociate()
    {
        return ((delegate* unmanaged[MemberFunction]<IAMDeviceRemoval*, int>)(lpVtbl[5]))((IAMDeviceRemoval*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DeviceInfo([NativeTypeName("CLSID *")] Guid* pclsidInterfaceClass, [NativeTypeName("LPWSTR *")] char** pwszSymbolicLink);

        [VtblIndex(4)]
        HRESULT Reassociate();

        [VtblIndex(5)]
        HRESULT Disassociate();
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

        [NativeTypeName("HRESULT (CLSID *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, int> DeviceInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reassociate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Disassociate;
    }
}
