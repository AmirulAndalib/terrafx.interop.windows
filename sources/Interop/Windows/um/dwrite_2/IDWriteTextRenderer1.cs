// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("D3E0E934-22A0-427E-AAE4-7D9574B59DB1")]
    [NativeTypeName("struct IDWriteTextRenderer1 : IDWriteTextRenderer")]
    [NativeInheritance("IDWriteTextRenderer")]
    public unsafe partial struct IDWriteTextRenderer1 : IDWriteTextRenderer1.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, uint>)(lpVtbl[1]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, uint>)(lpVtbl[2]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT IsPixelSnappingDisabled(void* clientDrawingContext, BOOL* isDisabled)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, BOOL*, int>)(lpVtbl[3]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCurrentTransform(void* clientDrawingContext, DWRITE_MATRIX* transform)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, DWRITE_MATRIX*, int>)(lpVtbl[4]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float*, int>)(lpVtbl[5]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, IUnknown*, int>)(lpVtbl[6]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_UNDERLINE*, IUnknown*, int>)(lpVtbl[7]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_STRIKETHROUGH*, IUnknown*, int>)(lpVtbl[8]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT DrawInlineObject(void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, BOOL, BOOL, IUnknown*, int>)(lpVtbl[9]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, IUnknown*, int>)(lpVtbl[10]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, orientationAngle, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, DWRITE_UNDERLINE*, IUnknown*, int>)(lpVtbl[11]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, orientationAngle, underline, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, DWRITE_STRIKETHROUGH*, IUnknown*, int>)(lpVtbl[12]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, orientationAngle, strikethrough, clientDrawingEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT DrawInlineObject(void* clientDrawingContext, float originX, float originY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, IDWriteInlineObject* inlineObject, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect)
        {
            return ((delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, IDWriteInlineObject*, BOOL, BOOL, IUnknown*, int>)(lpVtbl[13]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, originX, originY, orientationAngle, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
        }

        public interface Interface : IDWriteTextRenderer.Interface
        {
            [VtblIndex(10)]
            HRESULT DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, IUnknown* clientDrawingEffect);

            [VtblIndex(11)]
            HRESULT DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, IUnknown* clientDrawingEffect);

            [VtblIndex(12)]
            HRESULT DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, IUnknown* clientDrawingEffect);

            [VtblIndex(13)]
            HRESULT DrawInlineObject(void* clientDrawingContext, float originX, float originY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, IDWriteInlineObject* inlineObject, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, uint> Release;

            [NativeTypeName("HRESULT (void *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, BOOL*, int> IsPixelSnappingDisabled;

            [NativeTypeName("HRESULT (void *, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, DWRITE_MATRIX*, int> GetCurrentTransform;

            [NativeTypeName("HRESULT (void *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float*, int> GetPixelsPerDip;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, IUnknown*, int> DrawGlyphRun;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, const DWRITE_UNDERLINE *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_UNDERLINE*, IUnknown*, int> DrawUnderline;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, const DWRITE_STRIKETHROUGH *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_STRIKETHROUGH*, IUnknown*, int> DrawStrikethrough;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, IDWriteInlineObject *, BOOL, BOOL, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, BOOL, BOOL, IUnknown*, int> DrawInlineObject;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, DWRITE_GLYPH_ORIENTATION_ANGLE, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, IUnknown*, int> DrawGlyphRun1;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, DWRITE_GLYPH_ORIENTATION_ANGLE, const DWRITE_UNDERLINE *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, DWRITE_UNDERLINE*, IUnknown*, int> DrawUnderline1;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, DWRITE_GLYPH_ORIENTATION_ANGLE, const DWRITE_STRIKETHROUGH *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, DWRITE_STRIKETHROUGH*, IUnknown*, int> DrawStrikethrough1;

            [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, DWRITE_GLYPH_ORIENTATION_ANGLE, IDWriteInlineObject *, BOOL, BOOL, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteTextRenderer1*, void*, float, float, DWRITE_GLYPH_ORIENTATION_ANGLE, IDWriteInlineObject*, BOOL, BOOL, IUnknown*, int> DrawInlineObject1;
        }
    }
}
