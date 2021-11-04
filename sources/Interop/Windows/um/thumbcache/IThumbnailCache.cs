// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F676C15D-596A-4CE2-8234-33996F445DB1")]
    [NativeTypeName("struct IThumbnailCache : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IThumbnailCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IThumbnailCache*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IThumbnailCache*, uint>)(lpVtbl[1]))((IThumbnailCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IThumbnailCache*, uint>)(lpVtbl[2]))((IThumbnailCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetThumbnail(IShellItem* pShellItem, uint cxyRequestedThumbSize, WTS_FLAGS flags, ISharedBitmap** ppvThumb, WTS_CACHEFLAGS* pOutFlags, WTS_THUMBNAILID* pThumbnailID)
        {
            return ((delegate* unmanaged<IThumbnailCache*, IShellItem*, uint, WTS_FLAGS, ISharedBitmap**, WTS_CACHEFLAGS*, WTS_THUMBNAILID*, int>)(lpVtbl[3]))((IThumbnailCache*)Unsafe.AsPointer(ref this), pShellItem, cxyRequestedThumbSize, flags, ppvThumb, pOutFlags, pThumbnailID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetThumbnailByID(WTS_THUMBNAILID thumbnailID, uint cxyRequestedThumbSize, ISharedBitmap** ppvThumb, WTS_CACHEFLAGS* pOutFlags)
        {
            return ((delegate* unmanaged<IThumbnailCache*, WTS_THUMBNAILID, uint, ISharedBitmap**, WTS_CACHEFLAGS*, int>)(lpVtbl[4]))((IThumbnailCache*)Unsafe.AsPointer(ref this), thumbnailID, cxyRequestedThumbSize, ppvThumb, pOutFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IThumbnailCache*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IThumbnailCache*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IThumbnailCache*, uint> Release;

            [NativeTypeName("HRESULT (IShellItem *, UINT, WTS_FLAGS, ISharedBitmap **, WTS_CACHEFLAGS *, WTS_THUMBNAILID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IThumbnailCache*, IShellItem*, uint, WTS_FLAGS, ISharedBitmap**, WTS_CACHEFLAGS*, WTS_THUMBNAILID*, int> GetThumbnail;

            [NativeTypeName("HRESULT (WTS_THUMBNAILID, UINT, ISharedBitmap **, WTS_CACHEFLAGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IThumbnailCache*, WTS_THUMBNAILID, uint, ISharedBitmap**, WTS_CACHEFLAGS*, int> GetThumbnailByID;
        }
    }
}
