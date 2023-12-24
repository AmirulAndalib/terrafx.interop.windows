// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IBindProtocol.xml' path='doc/member[@name="IBindProtocol"]/*' />
[Guid("79EAC9CD-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IBindProtocol : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindProtocol : IBindProtocol.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindProtocol));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindProtocol*, Guid*, void**, int>)(lpVtbl[0]))((IBindProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBindProtocol*, uint>)(lpVtbl[1]))((IBindProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBindProtocol*, uint>)(lpVtbl[2]))((IBindProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBindProtocol.xml' path='doc/member[@name="IBindProtocol.CreateBinding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBinding([NativeTypeName("LPCWSTR")] char* szUrl, IBindCtx* pbc, IBinding** ppb)
    {
        return ((delegate* unmanaged[MemberFunction]<IBindProtocol*, char*, IBindCtx*, IBinding**, int>)(lpVtbl[3]))((IBindProtocol*)Unsafe.AsPointer(ref this), szUrl, pbc, ppb);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateBinding([NativeTypeName("LPCWSTR")] char* szUrl, IBindCtx* pbc, IBinding** ppb);
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

        [NativeTypeName("HRESULT (LPCWSTR, IBindCtx *, IBinding **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IBindCtx*, IBinding**, int> CreateBinding;
    }
}
