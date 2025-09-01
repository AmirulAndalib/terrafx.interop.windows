// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITravelLogEntry.xml' path='doc/member[@name="ITravelLogEntry"]/*' />
[Guid("7EBFDD87-AD18-11D3-A4C5-00C04F72D6B8")]
[NativeTypeName("struct ITravelLogEntry : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITravelLogEntry : ITravelLogEntry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITravelLogEntry);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogEntry*, Guid*, void**, int>)(lpVtbl[0]))((ITravelLogEntry*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogEntry*, uint>)(lpVtbl[1]))((ITravelLogEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogEntry*, uint>)(lpVtbl[2]))((ITravelLogEntry*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITravelLogEntry.xml' path='doc/member[@name="ITravelLogEntry.GetTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTitle([NativeTypeName("LPWSTR *")] char** ppszTitle)
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogEntry*, char**, int>)(lpVtbl[3]))((ITravelLogEntry*)Unsafe.AsPointer(ref this), ppszTitle);
    }

    /// <include file='ITravelLogEntry.xml' path='doc/member[@name="ITravelLogEntry.GetURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPWSTR *")] char** ppszURL)
    {
        return ((delegate* unmanaged[MemberFunction]<ITravelLogEntry*, char**, int>)(lpVtbl[4]))((ITravelLogEntry*)Unsafe.AsPointer(ref this), ppszURL);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTitle([NativeTypeName("LPWSTR *")] char** ppszTitle);

        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPWSTR *")] char** ppszURL);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetTitle;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetURL;
    }
}
