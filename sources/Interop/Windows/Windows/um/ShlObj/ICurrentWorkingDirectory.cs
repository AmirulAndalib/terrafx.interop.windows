// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICurrentWorkingDirectory.xml' path='doc/member[@name="ICurrentWorkingDirectory"]/*' />
[Guid("91956D21-9276-11D1-921A-006097DF5BD4")]
[NativeTypeName("struct ICurrentWorkingDirectory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICurrentWorkingDirectory : ICurrentWorkingDirectory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICurrentWorkingDirectory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentWorkingDirectory*, Guid*, void**, int>)(lpVtbl[0]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentWorkingDirectory*, uint>)(lpVtbl[1]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentWorkingDirectory*, uint>)(lpVtbl[2]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICurrentWorkingDirectory.xml' path='doc/member[@name="ICurrentWorkingDirectory.GetDirectory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDirectory([NativeTypeName("PWSTR")] char* pwzPath, [NativeTypeName("DWORD")] uint cchSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentWorkingDirectory*, char*, uint, int>)(lpVtbl[3]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this), pwzPath, cchSize);
    }

    /// <include file='ICurrentWorkingDirectory.xml' path='doc/member[@name="ICurrentWorkingDirectory.SetDirectory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDirectory([NativeTypeName("PCWSTR")] char* pwzPath)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrentWorkingDirectory*, char*, int>)(lpVtbl[4]))((ICurrentWorkingDirectory*)Unsafe.AsPointer(ref this), pwzPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDirectory([NativeTypeName("PWSTR")] char* pwzPath, [NativeTypeName("DWORD")] uint cchSize);

        [VtblIndex(4)]
        HRESULT SetDirectory([NativeTypeName("PCWSTR")] char* pwzPath);
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

        [NativeTypeName("HRESULT (PWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> GetDirectory;

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetDirectory;
    }
}
