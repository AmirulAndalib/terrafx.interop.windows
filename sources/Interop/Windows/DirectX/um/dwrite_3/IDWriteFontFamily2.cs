// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDWriteFontFamily2.xml' path='doc/member[@name="IDWriteFontFamily2"]/*' />
[Guid("3ED49E77-A398-4261-B9CF-C126C2131EF3")]
[NativeTypeName("struct IDWriteFontFamily2 : IDWriteFontFamily1")]
[NativeInheritance("IDWriteFontFamily1")]
public unsafe partial struct IDWriteFontFamily2 : IDWriteFontFamily2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFamily2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, uint>)(lpVtbl[1]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, uint>)(lpVtbl[2]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontList.GetFontCollection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, IDWriteFontCollection**, int>)(lpVtbl[3]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <inheritdoc cref="IDWriteFontList.GetFontCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, uint>)(lpVtbl[4]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontList.GetFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, uint, IDWriteFont**, int>)(lpVtbl[5]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), index, font);
    }

    /// <inheritdoc cref="IDWriteFontFamily.GetFamilyNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFamilyNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, IDWriteLocalizedStrings**, int>)(lpVtbl[6]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), names);
    }

    /// <inheritdoc cref="IDWriteFontFamily.GetFirstMatchingFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFont** matchingFont)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont**, int>)(lpVtbl[7]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFont);
    }

    /// <inheritdoc cref="IDWriteFontFamily.GetMatchingFonts" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFontList** matchingFonts)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList**, int>)(lpVtbl[8]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFonts);
    }

    /// <inheritdoc cref="IDWriteFontFamily1.GetFontLocality" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, uint, DWRITE_LOCALITY>)(lpVtbl[9]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), listIndex);
    }

    /// <inheritdoc cref="IDWriteFontFamily1.GetFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3** font)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, uint, IDWriteFont3**, int>)(lpVtbl[10]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), listIndex, font);
    }

    /// <inheritdoc cref="IDWriteFontFamily1.GetFontFaceReference" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[11]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
    }

    /// <include file='IDWriteFontFamily2.xml' path='doc/member[@name="IDWriteFontFamily2.GetMatchingFonts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontList2** matchingFonts)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int>)(lpVtbl[12]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount, matchingFonts);
    }

    /// <include file='IDWriteFontFamily2.xml' path='doc/member[@name="IDWriteFontFamily2.GetFontSet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFontSet(IDWriteFontSet1** fontSet)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontFamily2*, IDWriteFontSet1**, int>)(lpVtbl[13]))((IDWriteFontFamily2*)Unsafe.AsPointer(ref this), fontSet);
    }

    public interface Interface : IDWriteFontFamily1.Interface
    {
        [VtblIndex(12)]
        HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontList2** matchingFonts);

        [VtblIndex(13)]
        HRESULT GetFontSet(IDWriteFontSet1** fontSet);
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

        [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontCollection**, int> GetFontCollection;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetFontCount;

        [NativeTypeName("HRESULT (UINT32, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDWriteFont**, int> GetFont;

        [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteLocalizedStrings**, int> GetFamilyNames;

        [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont**, int> GetFirstMatchingFont;

        [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList**, int> GetMatchingFonts;

        [NativeTypeName("DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DWRITE_LOCALITY> GetFontLocality;

        [NativeTypeName("HRESULT (UINT32, IDWriteFont3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDWriteFont3**, int> GetFont1;

        [NativeTypeName("HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDWriteFontFaceReference**, int> GetFontFaceReference;

        [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int> GetMatchingFonts1;

        [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontSet1**, int> GetFontSet;
    }
}
