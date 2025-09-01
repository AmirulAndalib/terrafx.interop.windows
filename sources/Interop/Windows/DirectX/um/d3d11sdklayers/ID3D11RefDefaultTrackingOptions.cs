// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D11RefDefaultTrackingOptions.xml' path='doc/member[@name="ID3D11RefDefaultTrackingOptions"]/*' />
[Guid("03916615-C644-418C-9BF4-75DB5BE63CA0")]
[NativeTypeName("struct ID3D11RefDefaultTrackingOptions : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11RefDefaultTrackingOptions : ID3D11RefDefaultTrackingOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D11RefDefaultTrackingOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11RefDefaultTrackingOptions*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11RefDefaultTrackingOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11RefDefaultTrackingOptions*, uint>)(lpVtbl[1]))((ID3D11RefDefaultTrackingOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11RefDefaultTrackingOptions*, uint>)(lpVtbl[2]))((ID3D11RefDefaultTrackingOptions*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11RefDefaultTrackingOptions.xml' path='doc/member[@name="ID3D11RefDefaultTrackingOptions.SetTrackingOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTrackingOptions(uint ResourceTypeFlags, uint Options)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D11RefDefaultTrackingOptions*, uint, uint, int>)(lpVtbl[3]))((ID3D11RefDefaultTrackingOptions*)Unsafe.AsPointer(ref this), ResourceTypeFlags, Options);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetTrackingOptions(uint ResourceTypeFlags, uint Options);
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

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> SetTrackingOptions;
    }
}
