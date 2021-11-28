// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("4EA39266-7211-409F-B622-F63DBD16C533")]
[NativeTypeName("struct IThumbnailCapture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IThumbnailCapture : IThumbnailCapture.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailCapture*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailCapture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IThumbnailCapture*, uint>)(lpVtbl[1]))((IThumbnailCapture*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailCapture*, uint>)(lpVtbl[2]))((IThumbnailCapture*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CaptureThumbnail([NativeTypeName("const SIZE *")] SIZE* pMaxSize, IUnknown* pHTMLDoc2, HBITMAP* phbmThumbnail)
    {
        return ((delegate* unmanaged<IThumbnailCapture*, SIZE*, IUnknown*, HBITMAP*, int>)(lpVtbl[3]))((IThumbnailCapture*)Unsafe.AsPointer(ref this), pMaxSize, pHTMLDoc2, phbmThumbnail);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CaptureThumbnail([NativeTypeName("const SIZE *")] SIZE* pMaxSize, IUnknown* pHTMLDoc2, HBITMAP* phbmThumbnail);
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

        [NativeTypeName("HRESULT (const SIZE *, IUnknown *, HBITMAP *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, IUnknown*, HBITMAP*, int> CaptureThumbnail;
    }
}
