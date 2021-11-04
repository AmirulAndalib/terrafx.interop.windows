// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1EDD9491-9853-4299-898F-6432983B6F3A")]
    [NativeTypeName("struct IDWriteGdiInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteGdiInterop : IDWriteGdiInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, uint>)(lpVtbl[1]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, uint>)(lpVtbl[2]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, LOGFONTW*, IDWriteFont**, int>)(lpVtbl[3]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), logFont, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ConvertFontToLOGFONT(IDWriteFont* font, LOGFONTW* logFont, BOOL* isSystemFont)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, IDWriteFont*, LOGFONTW*, BOOL*, int>)(lpVtbl[4]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ConvertFontFaceToLOGFONT(IDWriteFontFace* font, LOGFONTW* logFont)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, IDWriteFontFace*, LOGFONTW*, int>)(lpVtbl[5]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), font, logFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateFontFaceFromHdc(HDC hdc, IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, HDC, IDWriteFontFace**, int>)(lpVtbl[6]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), hdc, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateBitmapRenderTarget(HDC hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, IDWriteBitmapRenderTarget** renderTarget)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop*, HDC, uint, uint, IDWriteBitmapRenderTarget**, int>)(lpVtbl[7]))((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, IDWriteFont** font);

            [VtblIndex(4)]
            HRESULT ConvertFontToLOGFONT(IDWriteFont* font, LOGFONTW* logFont, BOOL* isSystemFont);

            [VtblIndex(5)]
            HRESULT ConvertFontFaceToLOGFONT(IDWriteFontFace* font, LOGFONTW* logFont);

            [VtblIndex(6)]
            HRESULT CreateFontFaceFromHdc(HDC hdc, IDWriteFontFace** fontFace);

            [VtblIndex(7)]
            HRESULT CreateBitmapRenderTarget(HDC hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, IDWriteBitmapRenderTarget** renderTarget);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, uint> Release;

            [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, LOGFONTW*, IDWriteFont**, int> CreateFontFromLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFont *, LOGFONTW *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, IDWriteFont*, LOGFONTW*, BOOL*, int> ConvertFontToLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFontFace *, LOGFONTW *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, IDWriteFontFace*, LOGFONTW*, int> ConvertFontFaceToLOGFONT;

            [NativeTypeName("HRESULT (HDC, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, HDC, IDWriteFontFace**, int> CreateFontFaceFromHdc;

            [NativeTypeName("HRESULT (HDC, UINT32, UINT32, IDWriteBitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteGdiInterop*, HDC, uint, uint, IDWriteBitmapRenderTarget**, int> CreateBitmapRenderTarget;
        }
    }
}
