// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1"]/*' />
[Guid("5F174B49-0D8B-4CFB-8BCA-F1CCE9D06C67")]
[NativeTypeName("struct IDWriteTextFormat1 : IDWriteTextFormat")]
[NativeInheritance("IDWriteTextFormat")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteTextFormat1 : IDWriteTextFormat1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextFormat1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[1]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[2]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetTextAlignment" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), textAlignment);
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetParagraphAlignment" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), paragraphAlignment);
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetWordWrapping" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), wordWrapping);
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetReadingDirection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), readingDirection);
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetFlowDirection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), flowDirection);
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetIncrementalTabStop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetIncrementalTabStop(float incrementalTabStop)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, float, int>)(lpVtbl[8]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), incrementalTabStop);
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetTrimming" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <inheritdoc cref="IDWriteTextFormat.SetLineSpacing" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetTextAlignment" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetParagraphAlignment" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetWordWrapping" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DWRITE_WORD_WRAPPING GetWordWrapping()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetReadingDirection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public DWRITE_READING_DIRECTION GetReadingDirection()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFlowDirection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public DWRITE_FLOW_DIRECTION GetFlowDirection()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetIncrementalTabStop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public float GetIncrementalTabStop()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, float>)(lpVtbl[16]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetTrimming" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetLineSpacing" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFontCollection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyNameLength" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[20]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFontWeight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public DWRITE_FONT_WEIGHT GetFontWeight()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFontStyle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public DWRITE_FONT_STYLE GetFontStyle()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFontStretch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public DWRITE_FONT_STRETCH GetFontStretch()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetFontSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public float GetFontSize()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, float>)(lpVtbl[25]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetLocaleNameLength" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("UINT32")]
    public uint GetLocaleNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, uint>)(lpVtbl[26]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteTextFormat.GetLocaleName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), localeName, nameSize);
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.SetVerticalGlyphOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[28]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), glyphOrientation);
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.GetVerticalGlyphOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[29]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.SetLastLineWrapping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetLastLineWrapping(BOOL isLastLineWrappingEnabled)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, BOOL, int>)(lpVtbl[30]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.GetLastLineWrapping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public BOOL GetLastLineWrapping()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, int>)(lpVtbl[31]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.SetOpticalAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[32]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), opticalAlignment);
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.GetOpticalAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[33]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.SetFontFallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetFontFallback(IDWriteFontFallback* fontFallback)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, IDWriteFontFallback*, int>)(lpVtbl[34]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
    }

    /// <include file='IDWriteTextFormat1.xml' path='doc/member[@name="IDWriteTextFormat1.GetFontFallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetFontFallback(IDWriteFontFallback** fontFallback)
    {
        return ((delegate* unmanaged<IDWriteTextFormat1*, IDWriteFontFallback**, int>)(lpVtbl[35]))((IDWriteTextFormat1*)Unsafe.AsPointer(ref this), fontFallback);
    }

    public interface Interface : IDWriteTextFormat.Interface
    {
        [VtblIndex(28)]
        HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);

        [VtblIndex(29)]
        DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation();

        [VtblIndex(30)]
        HRESULT SetLastLineWrapping(BOOL isLastLineWrappingEnabled);

        [VtblIndex(31)]
        BOOL GetLastLineWrapping();

        [VtblIndex(32)]
        HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment);

        [VtblIndex(33)]
        DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment();

        [VtblIndex(34)]
        HRESULT SetFontFallback(IDWriteFontFallback* fontFallback);

        [VtblIndex(35)]
        HRESULT GetFontFallback(IDWriteFontFallback** fontFallback);
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

        [NativeTypeName("HRESULT (DWRITE_TEXT_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_ALIGNMENT, int> SetTextAlignment;

        [NativeTypeName("HRESULT (DWRITE_PARAGRAPH_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PARAGRAPH_ALIGNMENT, int> SetParagraphAlignment;

        [NativeTypeName("HRESULT (DWRITE_WORD_WRAPPING) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_WORD_WRAPPING, int> SetWordWrapping;

        [NativeTypeName("HRESULT (DWRITE_READING_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_READING_DIRECTION, int> SetReadingDirection;

        [NativeTypeName("HRESULT (DWRITE_FLOW_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FLOW_DIRECTION, int> SetFlowDirection;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetIncrementalTabStop;

        [NativeTypeName("HRESULT (const DWRITE_TRIMMING *, IDWriteInlineObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TRIMMING*, IDWriteInlineObject*, int> SetTrimming;

        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_SPACING_METHOD, float, float, int> SetLineSpacing;

        [NativeTypeName("DWRITE_TEXT_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_ALIGNMENT> GetTextAlignment;

        [NativeTypeName("DWRITE_PARAGRAPH_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PARAGRAPH_ALIGNMENT> GetParagraphAlignment;

        [NativeTypeName("DWRITE_WORD_WRAPPING () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_WORD_WRAPPING> GetWordWrapping;

        [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_READING_DIRECTION> GetReadingDirection;

        [NativeTypeName("DWRITE_FLOW_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FLOW_DIRECTION> GetFlowDirection;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetIncrementalTabStop;

        [NativeTypeName("HRESULT (DWRITE_TRIMMING *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TRIMMING*, IDWriteInlineObject**, int> GetTrimming;

        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int> GetLineSpacing;

        [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection**, int> GetFontCollection;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFamilyNameLength;

        [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetFontFamilyName;

        [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT> GetFontWeight;

        [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STYLE> GetFontStyle;

        [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STRETCH> GetFontStretch;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetFontSize;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLocaleNameLength;

        [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetLocaleName;

        [NativeTypeName("HRESULT (DWRITE_VERTICAL_GLYPH_ORIENTATION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int> SetVerticalGlyphOrientation;

        [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_VERTICAL_GLYPH_ORIENTATION> GetVerticalGlyphOrientation;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetLastLineWrapping;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetLastLineWrapping;

        [NativeTypeName("HRESULT (DWRITE_OPTICAL_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_OPTICAL_ALIGNMENT, int> SetOpticalAlignment;

        [NativeTypeName("DWRITE_OPTICAL_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_OPTICAL_ALIGNMENT> GetOpticalAlignment;

        [NativeTypeName("HRESULT (IDWriteFontFallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallback*, int> SetFontFallback;

        [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallback**, int> GetFontFallback;
    }
}
