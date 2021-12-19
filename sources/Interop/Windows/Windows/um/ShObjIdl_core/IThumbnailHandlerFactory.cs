// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IThumbnailHandlerFactory.xml' path='doc/member[@name="IThumbnailHandlerFactory"]/*' />
[Guid("E35B4B2E-00DA-4BC1-9F13-38BC11F5D417")]
[NativeTypeName("struct IThumbnailHandlerFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IThumbnailHandlerFactory : IThumbnailHandlerFactory.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailHandlerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailHandlerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IThumbnailHandlerFactory*, uint>)(lpVtbl[1]))((IThumbnailHandlerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailHandlerFactory*, uint>)(lpVtbl[2]))((IThumbnailHandlerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IThumbnailHandlerFactory.xml' path='doc/member[@name="IThumbnailHandlerFactory.GetThumbnailHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetThumbnailHandler([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IThumbnailHandlerFactory*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int>)(lpVtbl[3]))((IThumbnailHandlerFactory*)Unsafe.AsPointer(ref this), pidlChild, pbc, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetThumbnailHandler([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName("HRESULT (LPCITEMIDLIST, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int> GetThumbnailHandler;
    }
}
