// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxManifestApplication.xml' path='doc/member[@name="IAppxManifestApplication"]/*' />
[Guid("5DA89BF4-3773-46BE-B650-7E744863B7E8")]
[NativeTypeName("struct IAppxManifestApplication : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestApplication : IAppxManifestApplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestApplication));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestApplication*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestApplication*, uint>)(lpVtbl[1]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestApplication*, uint>)(lpVtbl[2]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestApplication.xml' path='doc/member[@name="IAppxManifestApplication.GetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* name, [NativeTypeName("LPWSTR *")] char** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestApplication*, char*, char**, int>)(lpVtbl[3]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IAppxManifestApplication.xml' path='doc/member[@name="IAppxManifestApplication.GetAppUserModelId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAppUserModelId([NativeTypeName("LPWSTR *")] char** appUserModelId)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppxManifestApplication*, char**, int>)(lpVtbl[4]))((IAppxManifestApplication*)Unsafe.AsPointer(ref this), appUserModelId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* name, [NativeTypeName("LPWSTR *")] char** value);

        [VtblIndex(4)]
        HRESULT GetAppUserModelId([NativeTypeName("LPWSTR *")] char** appUserModelId);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetStringValue;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetAppUserModelId;
    }
}
