// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("7D97DBF7-E085-42D4-81E3-6A883BDED118")]
[NativeTypeName("struct IDWriteGlyphRunAnalysis : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteGlyphRunAnalysis : IDWriteGlyphRunAnalysis.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteGlyphRunAnalysis*, uint>)(lpVtbl[1]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteGlyphRunAnalysis*, uint>)(lpVtbl[2]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds)
    {
        return ((delegate* unmanaged<IDWriteGlyphRunAnalysis*, DWRITE_TEXTURE_TYPE, RECT*, int>)(lpVtbl[3]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("const RECT *")] RECT* textureBounds, byte* alphaValues, [NativeTypeName("UINT32")] uint bufferSize)
    {
        return ((delegate* unmanaged<IDWriteGlyphRunAnalysis*, DWRITE_TEXTURE_TYPE, RECT*, byte*, uint, int>)(lpVtbl[4]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds, alphaValues, bufferSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
    {
        return ((delegate* unmanaged<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)(lpVtbl[5]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAlphaTextureBounds(DWRITE_TEXTURE_TYPE textureType, RECT* textureBounds);

        [VtblIndex(4)]
        HRESULT CreateAlphaTexture(DWRITE_TEXTURE_TYPE textureType, [NativeTypeName("const RECT *")] RECT* textureBounds, byte* alphaValues, [NativeTypeName("UINT32")] uint bufferSize);

        [VtblIndex(5)]
        HRESULT GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteGlyphRunAnalysis*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteGlyphRunAnalysis*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteGlyphRunAnalysis*, uint> Release;

        [NativeTypeName("HRESULT (DWRITE_TEXTURE_TYPE, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteGlyphRunAnalysis*, DWRITE_TEXTURE_TYPE, RECT*, int> GetAlphaTextureBounds;

        [NativeTypeName("HRESULT (DWRITE_TEXTURE_TYPE, const RECT *, BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteGlyphRunAnalysis*, DWRITE_TEXTURE_TYPE, RECT*, byte*, uint, int> CreateAlphaTexture;

        [NativeTypeName("HRESULT (IDWriteRenderingParams *, FLOAT *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int> GetAlphaBlendParams;
    }
}
