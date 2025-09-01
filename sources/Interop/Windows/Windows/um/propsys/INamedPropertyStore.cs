// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='INamedPropertyStore.xml' path='doc/member[@name="INamedPropertyStore"]/*' />
[Guid("71604B0F-97B0-4764-8577-2F13E98A1422")]
[NativeTypeName("struct INamedPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INamedPropertyStore : INamedPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_INamedPropertyStore);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INamedPropertyStore*, Guid*, void**, int>)(lpVtbl[0]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INamedPropertyStore*, uint>)(lpVtbl[1]))((INamedPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INamedPropertyStore*, uint>)(lpVtbl[2]))((INamedPropertyStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INamedPropertyStore.xml' path='doc/member[@name="INamedPropertyStore.GetNamedValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNamedValue([NativeTypeName("LPCWSTR")] char* pszName, PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged[MemberFunction]<INamedPropertyStore*, char*, PROPVARIANT*, int>)(lpVtbl[3]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pszName, ppropvar);
    }

    /// <include file='INamedPropertyStore.xml' path='doc/member[@name="INamedPropertyStore.SetNamedValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNamedValue([NativeTypeName("LPCWSTR")] char* pszName, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
    {
        return ((delegate* unmanaged[MemberFunction]<INamedPropertyStore*, char*, PROPVARIANT*, int>)(lpVtbl[4]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pszName, propvar);
    }

    /// <include file='INamedPropertyStore.xml' path='doc/member[@name="INamedPropertyStore.GetNameCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNameCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged[MemberFunction]<INamedPropertyStore*, uint*, int>)(lpVtbl[5]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='INamedPropertyStore.xml' path='doc/member[@name="INamedPropertyStore.GetNameAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNameAt([NativeTypeName("DWORD")] uint iProp, [NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<INamedPropertyStore*, uint, char**, int>)(lpVtbl[6]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), iProp, pbstrName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNamedValue([NativeTypeName("LPCWSTR")] char* pszName, PROPVARIANT* ppropvar);

        [VtblIndex(4)]
        HRESULT SetNamedValue([NativeTypeName("LPCWSTR")] char* pszName, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

        [VtblIndex(5)]
        HRESULT GetNameCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(6)]
        HRESULT GetNameAt([NativeTypeName("DWORD")] uint iProp, [NativeTypeName("BSTR *")] char** pbstrName);
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

        [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> GetNamedValue;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> SetNamedValue;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetNameCount;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> GetNameAt;
    }
}
