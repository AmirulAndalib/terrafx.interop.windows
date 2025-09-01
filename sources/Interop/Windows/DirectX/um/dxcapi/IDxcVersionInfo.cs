// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo"]/*' />
[Guid("B04F5B50-2059-4F12-A8FF-A1E0CDE1CC7E")]
[NativeTypeName("struct IDxcVersionInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcVersionInfo : IDxcVersionInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDxcVersionInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcVersionInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcVersionInfo*, uint>)(lpVtbl[1]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcVersionInfo*, uint>)(lpVtbl[2]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo.GetVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcVersionInfo*, uint*, uint*, int>)(lpVtbl[3]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pMajor, pMinor);
    }

    /// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo.GetFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcVersionInfo*, uint*, int>)(lpVtbl[4]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor);

        [VtblIndex(4)]
        HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags);
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

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetFlags;
    }
}
