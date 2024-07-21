// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDWriteFontFace6.xml' path='doc/member[@name="IDWriteFontFace6"]/*' />
[Guid("C4B1FE1B-6E84-47D5-B54C-A597981B06AD")]
[NativeTypeName("struct IDWriteFontFace6 : IDWriteFontFace5")]
[NativeInheritance("IDWriteFontFace5")]
public unsafe partial struct IDWriteFontFace6 : IDWriteFontFace6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint>)(lpVtbl[1]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint>)(lpVtbl[2]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public new DWRITE_FONT_FACE_TYPE GetType()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_FACE_TYPE>)(lpVtbl[3]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace.GetFiles" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
    }

    /// <inheritdoc cref="IDWriteFontFace.GetIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetIndex()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint>)(lpVtbl[5]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace.GetSimulations" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[6]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace.IsSymbolFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, int>)(lpVtbl[7]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace.GetMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_METRICS*, void>)(lpVtbl[8]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceMetrics);
    }

    /// <inheritdoc cref="IDWriteFontFace.GetGlyphCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT16")]
    public ushort GetGlyphCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, ushort>)(lpVtbl[9]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace.GetDesignGlyphMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int>)(lpVtbl[10]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <inheritdoc cref="IDWriteFontFace.GetGlyphIndices" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
    }

    /// <inheritdoc cref="IDWriteFontFace.TryGetFontTable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, void** tableContext, BOOL* exists)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, void**, uint*, void**, BOOL*, int>)(lpVtbl[12]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
    }

    /// <inheritdoc cref="IDWriteFontFace.ReleaseFontTable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ReleaseFontTable(void* tableContext)
    {
        ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, void*, void>)(lpVtbl[13]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), tableContext);
    }

    /// <inheritdoc cref="IDWriteFontFace.GetGlyphRunOutline" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGlyphRunOutline(float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, BOOL, BOOL, ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <inheritdoc cref="IDWriteFontFace.GetRecommendedRenderingMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int>)(lpVtbl[15]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
    }

    /// <inheritdoc cref="IDWriteFontFace.GetGdiCompatibleMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int>)(lpVtbl[16]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
    }

    /// <inheritdoc cref="IDWriteFontFace.GetGdiCompatibleGlyphMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, BOOL, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int>)(lpVtbl[17]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
    {
        ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[18]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetGdiCompatibleMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS1* fontMetrics)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int>)(lpVtbl[19]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetCaretMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics)
    {
        ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_CARET_METRICS*, void>)(lpVtbl[20]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), caretMetrics);
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetUnicodeRanges" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[21]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
    }

    /// <inheritdoc cref="IDWriteFontFace1.IsMonospacedFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL IsMonospacedFont()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, int>)(lpVtbl[22]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetDesignGlyphAdvances" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, ushort*, int*, BOOL, int>)(lpVtbl[23]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetGdiCompatibleGlyphAdvances" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, BOOL isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, DWRITE_MATRIX*, BOOL, BOOL, uint, ushort*, int*, int>)(lpVtbl[24]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetKerningPairAdjustments" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, ushort*, int*, int>)(lpVtbl[25]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
    }

    /// <inheritdoc cref="IDWriteFontFace1.HasKerningPairs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public BOOL HasKerningPairs()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, int>)(lpVtbl[26]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetRecommendedRenderingMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, DWRITE_RENDERING_MODE* renderingMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int>)(lpVtbl[27]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
    }

    /// <inheritdoc cref="IDWriteFontFace1.GetVerticalGlyphVariants" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, ushort*, ushort*, int>)(lpVtbl[28]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
    }

    /// <inheritdoc cref="IDWriteFontFace1.HasVerticalGlyphVariants" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public BOOL HasVerticalGlyphVariants()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, int>)(lpVtbl[29]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace2.IsColorFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public BOOL IsColorFont()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, int>)(lpVtbl[30]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace2.GetColorPaletteCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("UINT32")]
    public uint GetColorPaletteCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint>)(lpVtbl[31]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace2.GetPaletteEntryCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("UINT32")]
    public uint GetPaletteEntryCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint>)(lpVtbl[32]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace2.GetPaletteEntries" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetPaletteEntries([NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("UINT32")] uint firstEntryIndex, [NativeTypeName("UINT32")] uint entryCount, [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, uint, uint, DXGI_RGBA*, int>)(lpVtbl[33]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
    }

    /// <inheritdoc cref="IDWriteFontFace2.GetRecommendedRenderingMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int>)(lpVtbl[34]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetFontFaceReference" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, IDWriteFontFaceReference**, int>)(lpVtbl[35]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFaceReference);
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetPanose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void GetPanose(DWRITE_PANOSE* panose)
    {
        ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_PANOSE*, void>)(lpVtbl[36]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), panose);
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetWeight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public DWRITE_FONT_WEIGHT GetWeight()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_WEIGHT>)(lpVtbl[37]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetStretch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public DWRITE_FONT_STRETCH GetStretch()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_STRETCH>)(lpVtbl[38]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetStyle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public DWRITE_FONT_STYLE GetStyle()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_STYLE>)(lpVtbl[39]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetFamilyNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetFamilyNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[40]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetFaceNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetFaceNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, IDWriteLocalizedStrings**, int>)(lpVtbl[41]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), names);
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetInformationalStrings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int>)(lpVtbl[42]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
    }

    /// <inheritdoc cref="IDWriteFontFace3.HasCharacter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public BOOL HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, int>)(lpVtbl[43]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
    }

    /// <inheritdoc cref="IDWriteFontFace3.GetRecommendedRenderingMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE1* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE1*, DWRITE_GRID_FIT_MODE*, int>)(lpVtbl[44]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
    }

    /// <inheritdoc cref="IDWriteFontFace3.IsCharacterLocal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public BOOL IsCharacterLocal([NativeTypeName("UINT32")] uint unicodeValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint, int>)(lpVtbl[45]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), unicodeValue);
    }

    /// <inheritdoc cref="IDWriteFontFace3.IsGlyphLocal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public BOOL IsGlyphLocal([NativeTypeName("UINT16")] ushort glyphId)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, ushort, int>)(lpVtbl[46]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId);
    }

    /// <inheritdoc cref="IDWriteFontFace3.AreCharactersLocal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT AreCharactersLocal([NativeTypeName("const WCHAR *")] char* characters, [NativeTypeName("UINT32")] uint characterCount, BOOL enqueueIfNotLocal, BOOL* isLocal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, char*, uint, BOOL, BOOL*, int>)(lpVtbl[47]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
    }

    /// <inheritdoc cref="IDWriteFontFace3.AreGlyphsLocal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT AreGlyphsLocal([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, BOOL enqueueIfNotLocal, BOOL* isLocal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, ushort*, uint, BOOL, BOOL*, int>)(lpVtbl[48]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
    }

    /// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageFormats" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT GetGlyphImageFormats([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEmFirst, [NativeTypeName("UINT32")] uint pixelsPerEmLast, DWRITE_GLYPH_IMAGE_FORMATS* glyphImageFormats)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, ushort, uint, uint, DWRITE_GLYPH_IMAGE_FORMATS*, int>)(lpVtbl[49]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
    }

    /// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageFormats" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_GLYPH_IMAGE_FORMATS>)(lpVtbl[50]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT GetGlyphImageData([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEm, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, DWRITE_GLYPH_IMAGE_DATA* glyphData, void** glyphDataContext)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, ushort, uint, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA*, void**, int>)(lpVtbl[51]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
    }

    /// <inheritdoc cref="IDWriteFontFace4.ReleaseGlyphImageData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void ReleaseGlyphImageData(void* glyphDataContext)
    {
        ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, void*, void>)(lpVtbl[52]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), glyphDataContext);
    }

    /// <inheritdoc cref="IDWriteFontFace5.GetFontAxisValueCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontAxisValueCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, uint>)(lpVtbl[53]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace5.GetFontAxisValues" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[54]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
    }

    /// <inheritdoc cref="IDWriteFontFace5.HasVariations" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public BOOL HasVariations()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, int>)(lpVtbl[55]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontFace5.GetFontResource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetFontResource(IDWriteFontResource** fontResource)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, IDWriteFontResource**, int>)(lpVtbl[56]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontResource);
    }

    /// <inheritdoc cref="IDWriteFontFace5.Equals" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public BOOL Equals(IDWriteFontFace* fontFace)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, IDWriteFontFace*, int>)(lpVtbl[57]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFace);
    }

    /// <include file='IDWriteFontFace6.xml' path='doc/member[@name="IDWriteFontFace6.GetFamilyNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT GetFamilyNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings**, int>)(lpVtbl[58]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
    }

    /// <include file='IDWriteFontFace6.xml' path='doc/member[@name="IDWriteFontFace6.GetFaceNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT GetFaceNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFace6*, DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings**, int>)(lpVtbl[59]))((IDWriteFontFace6*)Unsafe.AsPointer(ref this), fontFamilyModel, names);
    }

    public interface Interface : IDWriteFontFace5.Interface
    {
        [VtblIndex(58)]
        HRESULT GetFamilyNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteLocalizedStrings** names);

        [VtblIndex(59)]
        HRESULT GetFaceNames(DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteLocalizedStrings** names);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("DWRITE_FONT_FACE_TYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_FACE_TYPE> GetType;

        [NativeTypeName("HRESULT (UINT32 *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, IDWriteFontFile**, int> GetFiles;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetIndex;

        [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_SIMULATIONS> GetSimulations;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsSymbolFont;

        [NativeTypeName("void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_METRICS*, void> GetMetrics;

        [NativeTypeName("UINT16 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort> GetGlyphCount;

        [NativeTypeName("HRESULT (const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> GetDesignGlyphMetrics;

        [NativeTypeName("HRESULT (const UINT32 *, UINT32, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint, ushort*, int> GetGlyphIndices;

        [NativeTypeName("HRESULT (UINT32, const void **, UINT32 *, void **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void**, uint*, void**, BOOL*, int> TryGetFontTable;

        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, void> ReleaseFontTable;

        [NativeTypeName("HRESULT (FLOAT, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, UINT32, BOOL, BOOL, IDWriteGeometrySink *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, BOOL, BOOL, ID2D1SimplifiedGeometrySink*, int> GetGlyphRunOutline;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int> GetRecommendedRenderingMode;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int> GetGdiCompatibleMetrics;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MATRIX*, BOOL, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> GetGdiCompatibleGlyphMetrics;

        [NativeTypeName("void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_METRICS1*, void> GetMetrics1;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int> GetGdiCompatibleMetrics1;

        [NativeTypeName("void (DWRITE_CARET_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_CARET_METRICS*, void> GetCaretMetrics;

        [NativeTypeName("HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DWRITE_UNICODE_RANGE*, uint*, int> GetUnicodeRanges;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsMonospacedFont;

        [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort*, int*, BOOL, int> GetDesignGlyphAdvances;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, DWRITE_MATRIX*, BOOL, BOOL, uint, ushort*, int*, int> GetGdiCompatibleGlyphAdvances;

        [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort*, int*, int> GetKerningPairAdjustments;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> HasKerningPairs;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int> GetRecommendedRenderingMode1;

        [NativeTypeName("HRESULT (UINT32, const UINT16 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort*, ushort*, int> GetVerticalGlyphVariants;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> HasVerticalGlyphVariants;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsColorFont;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetColorPaletteCount;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetPaletteEntryCount;

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, DWRITE_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, DXGI_RGBA*, int> GetPaletteEntries;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int> GetRecommendedRenderingMode2;

        [NativeTypeName("HRESULT (IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontFaceReference**, int> GetFontFaceReference;

        [NativeTypeName("void (DWRITE_PANOSE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_PANOSE*, void> GetPanose;

        [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_WEIGHT> GetWeight;

        [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_STRETCH> GetStretch;

        [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_STYLE> GetStyle;

        [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteLocalizedStrings**, int> GetFamilyNames;

        [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteLocalizedStrings**, int> GetFaceNames;

        [NativeTypeName("HRESULT (DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int> GetInformationalStrings;

        [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> HasCharacter;

        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE1 *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE1*, DWRITE_GRID_FIT_MODE*, int> GetRecommendedRenderingMode3;

        [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> IsCharacterLocal;

        [NativeTypeName("BOOL (UINT16) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int> IsGlyphLocal;

        [NativeTypeName("HRESULT (const WCHAR *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, BOOL, BOOL*, int> AreCharactersLocal;

        [NativeTypeName("HRESULT (const UINT16 *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, uint, BOOL, BOOL*, int> AreGlyphsLocal;

        [NativeTypeName("HRESULT (UINT16, UINT32, UINT32, DWRITE_GLYPH_IMAGE_FORMATS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, uint, uint, DWRITE_GLYPH_IMAGE_FORMATS*, int> GetGlyphImageFormats;

        [NativeTypeName("DWRITE_GLYPH_IMAGE_FORMATS () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_GLYPH_IMAGE_FORMATS> GetGlyphImageFormats1;

        [NativeTypeName("HRESULT (UINT16, UINT32, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, uint, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA*, void**, int> GetGlyphImageData;

        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, void> ReleaseGlyphImageData;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetFontAxisValueCount;

        [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_AXIS_VALUE*, uint, int> GetFontAxisValues;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> HasVariations;

        [NativeTypeName("HRESULT (IDWriteFontResource **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontResource**, int> GetFontResource;

        [NativeTypeName("BOOL (IDWriteFontFace *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontFace*, int> Equals;

        [NativeTypeName("HRESULT (DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings**, int> GetFamilyNames1;

        [NativeTypeName("HRESULT (DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings**, int> GetFaceNames1;
    }
}
