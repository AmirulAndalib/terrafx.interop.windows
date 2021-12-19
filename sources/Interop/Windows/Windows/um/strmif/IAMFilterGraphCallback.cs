// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IAMFilterGraphCallback.xml' path='doc/member[@name="IAMFilterGraphCallback"]/*' />
[NativeTypeName("struct IAMFilterGraphCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMFilterGraphCallback : IAMFilterGraphCallback.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMFilterGraphCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMFilterGraphCallback*, uint>)(lpVtbl[1]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMFilterGraphCallback*, uint>)(lpVtbl[2]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMFilterGraphCallback.xml' path='doc/member[@name="IAMFilterGraphCallback.UnableToRender"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UnableToRender(IPin* pPin)
    {
        return ((delegate* unmanaged<IAMFilterGraphCallback*, IPin*, int>)(lpVtbl[3]))((IAMFilterGraphCallback*)Unsafe.AsPointer(ref this), pPin);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UnableToRender(IPin* pPin);
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

        [NativeTypeName("HRESULT (IPin *)")]
        public delegate* unmanaged<TSelf*, IPin*, int> UnableToRender;
    }
}
