// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")]
    [NativeTypeName("struct IImageList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IImageList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IImageList*, Guid*, void**, int>)(lpVtbl[0]))((IImageList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IImageList*, uint>)(lpVtbl[1]))((IImageList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IImageList*, uint>)(lpVtbl[2]))((IImageList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Add(HBITMAP hbmImage, HBITMAP hbmMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList*, HBITMAP, HBITMAP, int*, int>)(lpVtbl[3]))((IImageList*)Unsafe.AsPointer(ref this), hbmImage, hbmMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ReplaceIcon(int i, HICON hicon, int* pi)
        {
            return ((delegate* unmanaged<IImageList*, int, HICON, int*, int>)(lpVtbl[4]))((IImageList*)Unsafe.AsPointer(ref this), i, hicon, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetOverlayImage(int iImage, int iOverlay)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int>)(lpVtbl[5]))((IImageList*)Unsafe.AsPointer(ref this), iImage, iOverlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Replace(int i, HBITMAP hbmImage, HBITMAP hbmMask)
        {
            return ((delegate* unmanaged<IImageList*, int, HBITMAP, HBITMAP, int>)(lpVtbl[6]))((IImageList*)Unsafe.AsPointer(ref this), i, hbmImage, hbmMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddMasked(HBITMAP hbmImage, COLORREF crMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList*, HBITMAP, COLORREF, int*, int>)(lpVtbl[7]))((IImageList*)Unsafe.AsPointer(ref this), hbmImage, crMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Draw(IMAGELISTDRAWPARAMS* pimldp)
        {
            return ((delegate* unmanaged<IImageList*, IMAGELISTDRAWPARAMS*, int>)(lpVtbl[8]))((IImageList*)Unsafe.AsPointer(ref this), pimldp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Remove(int i)
        {
            return ((delegate* unmanaged<IImageList*, int, int>)(lpVtbl[9]))((IImageList*)Unsafe.AsPointer(ref this), i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetIcon(int i, uint flags, HICON* picon)
        {
            return ((delegate* unmanaged<IImageList*, int, uint, HICON*, int>)(lpVtbl[10]))((IImageList*)Unsafe.AsPointer(ref this), i, flags, picon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetImageInfo(int i, IMAGEINFO* pImageInfo)
        {
            return ((delegate* unmanaged<IImageList*, int, IMAGEINFO*, int>)(lpVtbl[11]))((IImageList*)Unsafe.AsPointer(ref this), i, pImageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Copy(int iDst, IUnknown* punkSrc, int iSrc, uint uFlags)
        {
            return ((delegate* unmanaged<IImageList*, int, IUnknown*, int, uint, int>)(lpVtbl[12]))((IImageList*)Unsafe.AsPointer(ref this), iDst, punkSrc, iSrc, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Merge(int i1, IUnknown* punk2, int i2, int dx, int dy, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList*, int, IUnknown*, int, int, int, Guid*, void**, int>)(lpVtbl[13]))((IImageList*)Unsafe.AsPointer(ref this), i1, punk2, i2, dx, dy, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Clone([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList*, Guid*, void**, int>)(lpVtbl[14]))((IImageList*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetImageRect(int i, RECT* prc)
        {
            return ((delegate* unmanaged<IImageList*, int, RECT*, int>)(lpVtbl[15]))((IImageList*)Unsafe.AsPointer(ref this), i, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetIconSize(int* cx, int* cy)
        {
            return ((delegate* unmanaged<IImageList*, int*, int*, int>)(lpVtbl[16]))((IImageList*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetIconSize(int cx, int cy)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int>)(lpVtbl[17]))((IImageList*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetImageCount(int* pi)
        {
            return ((delegate* unmanaged<IImageList*, int*, int>)(lpVtbl[18]))((IImageList*)Unsafe.AsPointer(ref this), pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetImageCount(uint uNewCount)
        {
            return ((delegate* unmanaged<IImageList*, uint, int>)(lpVtbl[19]))((IImageList*)Unsafe.AsPointer(ref this), uNewCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetBkColor(COLORREF clrBk, COLORREF* pclr)
        {
            return ((delegate* unmanaged<IImageList*, COLORREF, COLORREF*, int>)(lpVtbl[20]))((IImageList*)Unsafe.AsPointer(ref this), clrBk, pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetBkColor(COLORREF* pclr)
        {
            return ((delegate* unmanaged<IImageList*, COLORREF*, int>)(lpVtbl[21]))((IImageList*)Unsafe.AsPointer(ref this), pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT BeginDrag(int iTrack, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int, int>)(lpVtbl[22]))((IImageList*)Unsafe.AsPointer(ref this), iTrack, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT EndDrag()
        {
            return ((delegate* unmanaged<IImageList*, int>)(lpVtbl[23]))((IImageList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT DragEnter(HWND hwndLock, int x, int y)
        {
            return ((delegate* unmanaged<IImageList*, HWND, int, int, int>)(lpVtbl[24]))((IImageList*)Unsafe.AsPointer(ref this), hwndLock, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT DragLeave(HWND hwndLock)
        {
            return ((delegate* unmanaged<IImageList*, HWND, int>)(lpVtbl[25]))((IImageList*)Unsafe.AsPointer(ref this), hwndLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT DragMove(int x, int y)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int>)(lpVtbl[26]))((IImageList*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetDragCursorImage(IUnknown* punk, int iDrag, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList*, IUnknown*, int, int, int, int>)(lpVtbl[27]))((IImageList*)Unsafe.AsPointer(ref this), punk, iDrag, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT DragShowNolock(BOOL fShow)
        {
            return ((delegate* unmanaged<IImageList*, BOOL, int>)(lpVtbl[28]))((IImageList*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetDragImage(POINT* ppt, POINT* pptHotspot, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList*, POINT*, POINT*, Guid*, void**, int>)(lpVtbl[29]))((IImageList*)Unsafe.AsPointer(ref this), ppt, pptHotspot, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetItemFlags(int i, [NativeTypeName("DWORD *")] uint* dwFlags)
        {
            return ((delegate* unmanaged<IImageList*, int, uint*, int>)(lpVtbl[30]))((IImageList*)Unsafe.AsPointer(ref this), i, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetOverlayImage(int iOverlay, int* piIndex)
        {
            return ((delegate* unmanaged<IImageList*, int, int*, int>)(lpVtbl[31]))((IImageList*)Unsafe.AsPointer(ref this), iOverlay, piIndex);
        }
    }
}
