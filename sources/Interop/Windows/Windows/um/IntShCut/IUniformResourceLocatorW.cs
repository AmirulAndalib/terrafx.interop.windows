// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW"]/*' />
[Guid("CABB0DA0-DA57-11CF-9974-0020AFD79762")]
[NativeTypeName("struct IUniformResourceLocatorW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUniformResourceLocatorW : IUniformResourceLocatorW.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUniformResourceLocatorW);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUniformResourceLocatorW*, Guid*, void**, int>)(lpVtbl[0]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUniformResourceLocatorW*, uint>)(lpVtbl[1]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUniformResourceLocatorW*, uint>)(lpVtbl[2]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW.SetURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetURL([NativeTypeName("LPCWSTR")] char* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IUniformResourceLocatorW*, char*, uint, int>)(lpVtbl[3]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), pcszURL, dwInFlags);
    }

    /// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW.GetURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPWSTR *")] char** ppszURL)
    {
        return ((delegate* unmanaged[MemberFunction]<IUniformResourceLocatorW*, char**, int>)(lpVtbl[4]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), ppszURL);
    }

    /// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW.InvokeCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOW")] URLINVOKECOMMANDINFOW* purlici)
    {
        return ((delegate* unmanaged[MemberFunction]<IUniformResourceLocatorW*, URLINVOKECOMMANDINFOW*, int>)(lpVtbl[5]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), purlici);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetURL([NativeTypeName("LPCWSTR")] char* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags);

        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPWSTR *")] char** ppszURL);

        [VtblIndex(5)]
        HRESULT InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOW")] URLINVOKECOMMANDINFOW* purlici);
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

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> SetURL;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetURL;

        [NativeTypeName("HRESULT (PURLINVOKECOMMANDINFOW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, URLINVOKECOMMANDINFOW*, int> InvokeCommand;
    }
}
