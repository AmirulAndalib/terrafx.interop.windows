// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDXGIDebug1.xml' path='doc/member[@name="IDXGIDebug1"]/*' />
[Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
[NativeTypeName("struct IDXGIDebug1 : IDXGIDebug")]
[NativeInheritance("IDXGIDebug")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDXGIDebug1 : IDXGIDebug1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDXGIDebug1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXGIDebug1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXGIDebug1*, uint>)(lpVtbl[1]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXGIDebug1*, uint>)(lpVtbl[2]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDXGIDebug.ReportLiveObjects" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDXGIDebug1*, Guid, DXGI_DEBUG_RLO_FLAGS, int>)(lpVtbl[3]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), apiid, flags);
    }

    /// <include file='IDXGIDebug1.xml' path='doc/member[@name="IDXGIDebug1.EnableLeakTrackingForThread"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void EnableLeakTrackingForThread()
    {
        ((delegate* unmanaged[MemberFunction]<IDXGIDebug1*, void>)(lpVtbl[4]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIDebug1.xml' path='doc/member[@name="IDXGIDebug1.DisableLeakTrackingForThread"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void DisableLeakTrackingForThread()
    {
        ((delegate* unmanaged[MemberFunction]<IDXGIDebug1*, void>)(lpVtbl[5]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIDebug1.xml' path='doc/member[@name="IDXGIDebug1.IsLeakTrackingEnabledForThread"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL IsLeakTrackingEnabledForThread()
    {
        return ((delegate* unmanaged[MemberFunction]<IDXGIDebug1*, int>)(lpVtbl[6]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDXGIDebug.Interface
    {
        [VtblIndex(4)]
        void EnableLeakTrackingForThread();

        [VtblIndex(5)]
        void DisableLeakTrackingForThread();

        [VtblIndex(6)]
        BOOL IsLeakTrackingEnabledForThread();
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

        [NativeTypeName("HRESULT (GUID, DXGI_DEBUG_RLO_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, DXGI_DEBUG_RLO_FLAGS, int> ReportLiveObjects;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> EnableLeakTrackingForThread;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DisableLeakTrackingForThread;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsLeakTrackingEnabledForThread;
    }
}
