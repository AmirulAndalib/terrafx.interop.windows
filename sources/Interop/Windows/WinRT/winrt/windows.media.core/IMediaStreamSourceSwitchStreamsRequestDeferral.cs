// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSourceSwitchStreamsRequestDeferral.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequestDeferral"]/*' />
[Guid("BEE3D835-A505-4F9A-B943-2B8CB1B4BBD9")]
[NativeTypeName("struct IMediaStreamSourceSwitchStreamsRequestDeferral : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSourceSwitchStreamsRequestDeferral : IMediaStreamSourceSwitchStreamsRequestDeferral.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSourceSwitchStreamsRequestDeferral));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestDeferral*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSourceSwitchStreamsRequestDeferral*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestDeferral*, uint>)(lpVtbl[1]))((IMediaStreamSourceSwitchStreamsRequestDeferral*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestDeferral*, uint>)(lpVtbl[2]))((IMediaStreamSourceSwitchStreamsRequestDeferral*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestDeferral*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSourceSwitchStreamsRequestDeferral*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestDeferral*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSourceSwitchStreamsRequestDeferral*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestDeferral*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSourceSwitchStreamsRequestDeferral*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSourceSwitchStreamsRequestDeferral.xml' path='doc/member[@name="IMediaStreamSourceSwitchStreamsRequestDeferral.Complete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Complete()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSourceSwitchStreamsRequestDeferral*, int>)(lpVtbl[6]))((IMediaStreamSourceSwitchStreamsRequestDeferral*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Complete();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Complete;
    }
}
