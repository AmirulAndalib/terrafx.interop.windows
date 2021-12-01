// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IBindCallbackRedirect.xml' path='doc/member[@name="IBindCallbackRedirect"]/*' />
[Guid("11C81BC2-121E-4ED5-B9C4-B430BD54F2C0")]
[NativeTypeName("struct IBindCallbackRedirect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindCallbackRedirect : IBindCallbackRedirect.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindCallbackRedirect*, Guid*, void**, int>)(lpVtbl[0]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBindCallbackRedirect*, uint>)(lpVtbl[1]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindCallbackRedirect*, uint>)(lpVtbl[2]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBindCallbackRedirect.xml' path='doc/member[@name="IBindCallbackRedirect.Redirect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Redirect([NativeTypeName("LPCWSTR")] ushort* lpcUrl, [NativeTypeName("VARIANT_BOOL *")] short* vbCancel)
    {
        return ((delegate* unmanaged<IBindCallbackRedirect*, ushort*, short*, int>)(lpVtbl[3]))((IBindCallbackRedirect*)Unsafe.AsPointer(ref this), lpcUrl, vbCancel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Redirect([NativeTypeName("LPCWSTR")] ushort* lpcUrl, [NativeTypeName("VARIANT_BOOL *")] short* vbCancel);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> Redirect;
    }
}
