// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F5185DD8-2012-4B0B-AAD9-F052C6BD482B")]
    [NativeTypeName("struct IPicture2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPicture2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPicture2*, Guid*, void**, int>)(lpVtbl[0]))((IPicture2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPicture2*, uint>)(lpVtbl[1]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPicture2*, uint>)(lpVtbl[2]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_Handle(HHANDLE* pHandle)
        {
            return ((delegate* unmanaged<IPicture2*, HHANDLE*, int>)(lpVtbl[3]))((IPicture2*)Unsafe.AsPointer(ref this), pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_hPal(HHANDLE* phPal)
        {
            return ((delegate* unmanaged<IPicture2*, HHANDLE*, int>)(lpVtbl[4]))((IPicture2*)Unsafe.AsPointer(ref this), phPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_Type(short* pType)
        {
            return ((delegate* unmanaged<IPicture2*, short*, int>)(lpVtbl[5]))((IPicture2*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return ((delegate* unmanaged<IPicture2*, int*, int>)(lpVtbl[6]))((IPicture2*)Unsafe.AsPointer(ref this), pWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return ((delegate* unmanaged<IPicture2*, int*, int>)(lpVtbl[7]))((IPicture2*)Unsafe.AsPointer(ref this), pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Render(HDC hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return ((delegate* unmanaged<IPicture2*, HDC, int, int, int, int, int, int, int, int, RECT*, int>)(lpVtbl[8]))((IPicture2*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT set_hPal(HHANDLE hPal)
        {
            return ((delegate* unmanaged<IPicture2*, HHANDLE, int>)(lpVtbl[9]))((IPicture2*)Unsafe.AsPointer(ref this), hPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_CurDC(HDC* phDC)
        {
            return ((delegate* unmanaged<IPicture2*, HDC*, int>)(lpVtbl[10]))((IPicture2*)Unsafe.AsPointer(ref this), phDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SelectPicture(HDC hDCIn, HDC* phDCOut, HHANDLE* phBmpOut)
        {
            return ((delegate* unmanaged<IPicture2*, HDC, HDC*, HHANDLE*, int>)(lpVtbl[11]))((IPicture2*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_KeepOriginalFormat(BOOL* pKeep)
        {
            return ((delegate* unmanaged<IPicture2*, BOOL*, int>)(lpVtbl[12]))((IPicture2*)Unsafe.AsPointer(ref this), pKeep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_KeepOriginalFormat(BOOL keep)
        {
            return ((delegate* unmanaged<IPicture2*, BOOL, int>)(lpVtbl[13]))((IPicture2*)Unsafe.AsPointer(ref this), keep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT PictureChanged()
        {
            return ((delegate* unmanaged<IPicture2*, int>)(lpVtbl[14]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, BOOL fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return ((delegate* unmanaged<IPicture2*, IStream*, BOOL, int*, int>)(lpVtbl[15]))((IPicture2*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return ((delegate* unmanaged<IPicture2*, uint*, int>)(lpVtbl[16]))((IPicture2*)Unsafe.AsPointer(ref this), pDwAttr);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, uint> Release;

            [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, HHANDLE*, int> get_Handle;

            [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, HHANDLE*, int> get_hPal;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, short*, int> get_Type;

            [NativeTypeName("HRESULT (OLE_XSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, int*, int> get_Width;

            [NativeTypeName("HRESULT (OLE_YSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, int*, int> get_Height;

            [NativeTypeName("HRESULT (HDC, LONG, LONG, LONG, LONG, OLE_XPOS_HIMETRIC, OLE_YPOS_HIMETRIC, OLE_XSIZE_HIMETRIC, OLE_YSIZE_HIMETRIC, LPCRECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, HDC, int, int, int, int, int, int, int, int, RECT*, int> Render;

            [NativeTypeName("HRESULT (HHANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, HHANDLE, int> set_hPal;

            [NativeTypeName("HRESULT (HDC *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, HDC*, int> get_CurDC;

            [NativeTypeName("HRESULT (HDC, HDC *, HHANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, HDC, HDC*, HHANDLE*, int> SelectPicture;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, BOOL*, int> get_KeepOriginalFormat;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, BOOL, int> put_KeepOriginalFormat;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, int> PictureChanged;

            [NativeTypeName("HRESULT (LPSTREAM, BOOL, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, IStream*, BOOL, int*, int> SaveAsFile;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPicture2*, uint*, int> get_Attributes;
        }
    }
}
