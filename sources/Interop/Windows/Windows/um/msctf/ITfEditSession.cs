// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITfEditSession.xml' path='doc/member[@name="ITfEditSession"]/*' />
[Guid("AA80E803-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfEditSession : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfEditSession : ITfEditSession.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ITfEditSession;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfEditSession*, Guid*, void**, int>)(lpVtbl[0]))((ITfEditSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfEditSession*, uint>)(lpVtbl[1]))((ITfEditSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfEditSession*, uint>)(lpVtbl[2]))((ITfEditSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfEditSession.xml' path='doc/member[@name="ITfEditSession.DoEditSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoEditSession([NativeTypeName("TfEditCookie")] uint ec)
    {
        return ((delegate* unmanaged<ITfEditSession*, uint, int>)(lpVtbl[3]))((ITfEditSession*)Unsafe.AsPointer(ref this), ec);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoEditSession([NativeTypeName("TfEditCookie")] uint ec);
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

        [NativeTypeName("HRESULT (TfEditCookie) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DoEditSession;
    }
}
