// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IQueryCancelAutoPlay.xml' path='doc/member[@name="IQueryCancelAutoPlay"]/*' />
[Guid("DDEFE873-6997-4E68-BE26-39B633ADBE12")]
[NativeTypeName("struct IQueryCancelAutoPlay : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQueryCancelAutoPlay : IQueryCancelAutoPlay.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryCancelAutoPlay));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryCancelAutoPlay*, Guid*, void**, int>)(lpVtbl[0]))((IQueryCancelAutoPlay*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryCancelAutoPlay*, uint>)(lpVtbl[1]))((IQueryCancelAutoPlay*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryCancelAutoPlay*, uint>)(lpVtbl[2]))((IQueryCancelAutoPlay*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IQueryCancelAutoPlay.xml' path='doc/member[@name="IQueryCancelAutoPlay.AllowAutoPlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AllowAutoPlay([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("DWORD")] uint dwContentType, [NativeTypeName("LPCWSTR")] char* pszLabel, [NativeTypeName("DWORD")] uint dwSerialNumber)
    {
        return ((delegate* unmanaged[MemberFunction]<IQueryCancelAutoPlay*, char*, uint, char*, uint, int>)(lpVtbl[3]))((IQueryCancelAutoPlay*)Unsafe.AsPointer(ref this), pszPath, dwContentType, pszLabel, dwSerialNumber);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AllowAutoPlay([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("DWORD")] uint dwContentType, [NativeTypeName("LPCWSTR")] char* pszLabel, [NativeTypeName("DWORD")] uint dwSerialNumber);
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

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, char*, uint, int> AllowAutoPlay;
    }
}
