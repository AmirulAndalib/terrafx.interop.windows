// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDWriteFontCollection3.xml' path='doc/member[@name="IDWriteFontCollection3"]/*' />
[Guid("A4D055A6-F9E3-4E25-93B7-9E309F3AF8E9")]
[NativeTypeName("struct IDWriteFontCollection3 : IDWriteFontCollection2")]
[NativeInheritance("IDWriteFontCollection2")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDWriteFontCollection3 : IDWriteFontCollection3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, uint>)(lpVtbl[1]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, uint>)(lpVtbl[2]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontCollection.GetFontFamilyCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, uint>)(lpVtbl[3]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontCollection.GetFontFamily" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
    }

    /// <inheritdoc cref="IDWriteFontCollection.FindFamilyName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFamilyName([NativeTypeName("const WCHAR *")] char* familyName, [NativeTypeName("UINT32 *")] uint* index, BOOL* exists)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, char*, uint*, BOOL*, int>)(lpVtbl[5]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, index, exists);
    }

    /// <inheritdoc cref="IDWriteFontCollection.GetFontFromFontFace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontFace, font);
    }

    /// <inheritdoc cref="IDWriteFontCollection1.GetFontSet" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFontSet(IDWriteFontSet** fontSet)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
    }

    /// <inheritdoc cref="IDWriteFontCollection1.GetFontFamily" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily1** fontFamily)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
    }

    /// <inheritdoc cref="IDWriteFontCollection2.GetFontFamily" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily2** fontFamily)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, uint, IDWriteFontFamily2**, int>)(lpVtbl[9]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), index, fontFamily);
    }

    /// <inheritdoc cref="IDWriteFontCollection2.GetMatchingFonts" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] char* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, char*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int>)(lpVtbl[10]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
    }

    /// <inheritdoc cref="IDWriteFontCollection2.GetFontFamilyModel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel()
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, DWRITE_FONT_FAMILY_MODEL>)(lpVtbl[11]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFontCollection2.GetFontSet" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFontSet(IDWriteFontSet1** fontSet)
    {
        return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, IDWriteFontSet1**, int>)(lpVtbl[12]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this), fontSet);
    }

    /// <include file='IDWriteFontCollection3.xml' path='doc/member[@name="IDWriteFontCollection3.GetExpirationEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HANDLE GetExpirationEvent()
    {
        return ((HANDLE)(((delegate* unmanaged[MemberFunction]<IDWriteFontCollection3*, void*>)(lpVtbl[13]))((IDWriteFontCollection3*)Unsafe.AsPointer(ref this))));
    }

    public interface Interface : IDWriteFontCollection2.Interface
    {
        [VtblIndex(13)]
        HANDLE GetExpirationEvent();
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

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetFontFamilyCount;

        [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDWriteFontFamily**, int> GetFontFamily;

        [NativeTypeName("HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, BOOL*, int> FindFamilyName;

        [NativeTypeName("HRESULT (IDWriteFontFace *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontFace*, IDWriteFont**, int> GetFontFromFontFace;

        [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontSet**, int> GetFontSet;

        [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDWriteFontFamily1**, int> GetFontFamily1;

        [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDWriteFontFamily2**, int> GetFontFamily2;

        [NativeTypeName("HRESULT (const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int> GetMatchingFonts;

        [NativeTypeName("DWRITE_FONT_FAMILY_MODEL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DWRITE_FONT_FAMILY_MODEL> GetFontFamilyModel;

        [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDWriteFontSet1**, int> GetFontSet1;

        [NativeTypeName("HANDLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*> GetExpirationEvent;
    }
}
