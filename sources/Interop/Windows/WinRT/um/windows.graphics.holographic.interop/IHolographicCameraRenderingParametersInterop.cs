// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHolographicCameraRenderingParametersInterop.xml' path='doc/member[@name="IHolographicCameraRenderingParametersInterop"]/*' />
[Guid("F75B68D6-D1FD-4707-AAFD-FA6F4C0E3BF4")]
[NativeTypeName("struct IHolographicCameraRenderingParametersInterop : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IHolographicCameraRenderingParametersInterop : IHolographicCameraRenderingParametersInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHolographicCameraRenderingParametersInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, uint>)(lpVtbl[1]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, uint>)(lpVtbl[2]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, HSTRING*, int>)(lpVtbl[4]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHolographicCameraRenderingParametersInterop.xml' path='doc/member[@name="IHolographicCameraRenderingParametersInterop.CommitDirect3D12Resource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CommitDirect3D12Resource(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[6]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue);
    }

    /// <include file='IHolographicCameraRenderingParametersInterop.xml' path='doc/member[@name="IHolographicCameraRenderingParametersInterop.CommitDirect3D12ResourceWithDepthData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CommitDirect3D12ResourceWithDepthData(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue, ID3D12Resource* pDepthResourceToCommit, ID3D12Fence* pDepthResourceFence, [NativeTypeName("UINT64")] ulong depthResourceFenceSignalValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHolographicCameraRenderingParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[7]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue, pDepthResourceToCommit, pDepthResourceFence, depthResourceFenceSignalValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CommitDirect3D12Resource(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue);

        [VtblIndex(7)]
        HRESULT CommitDirect3D12ResourceWithDepthData(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue, ID3D12Resource* pDepthResourceToCommit, ID3D12Fence* pDepthResourceFence, [NativeTypeName("UINT64")] ulong depthResourceFenceSignalValue);
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

        [NativeTypeName("HRESULT (ID3D12Resource *, ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, ID3D12Fence*, ulong, int> CommitDirect3D12Resource;

        [NativeTypeName("HRESULT (ID3D12Resource *, ID3D12Fence *, UINT64, ID3D12Resource *, ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12Resource*, ID3D12Fence*, ulong, ID3D12Resource*, ID3D12Fence*, ulong, int> CommitDirect3D12ResourceWithDepthData;
    }
}
