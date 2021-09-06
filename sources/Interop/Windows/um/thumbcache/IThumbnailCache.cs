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
    public unsafe partial struct IThumbnailCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IThumbnailCache*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IThumbnailCache*, uint>)(lpVtbl[1]))((IThumbnailCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IThumbnailCache*, uint>)(lpVtbl[2]))((IThumbnailCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(IShellItem* pShellItem, [NativeTypeName("UINT")] uint cxyRequestedThumbSize, WTS_FLAGS flags, ISharedBitmap** ppvThumb, WTS_CACHEFLAGS* pOutFlags, WTS_THUMBNAILID* pThumbnailID)
        {
            return ((delegate* unmanaged<IThumbnailCache*, IShellItem*, uint, WTS_FLAGS, ISharedBitmap**, WTS_CACHEFLAGS*, WTS_THUMBNAILID*, int>)(lpVtbl[3]))((IThumbnailCache*)Unsafe.AsPointer(ref this), pShellItem, cxyRequestedThumbSize, flags, ppvThumb, pOutFlags, pThumbnailID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnailByID(WTS_THUMBNAILID thumbnailID, [NativeTypeName("UINT")] uint cxyRequestedThumbSize, ISharedBitmap** ppvThumb, WTS_CACHEFLAGS* pOutFlags)
        {
            return ((delegate* unmanaged<IThumbnailCache*, WTS_THUMBNAILID, uint, ISharedBitmap**, WTS_CACHEFLAGS*, int>)(lpVtbl[4]))((IThumbnailCache*)Unsafe.AsPointer(ref this), thumbnailID, cxyRequestedThumbSize, ppvThumb, pOutFlags);
        }
    }
}
