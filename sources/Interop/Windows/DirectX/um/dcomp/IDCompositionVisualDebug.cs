// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("FED2B808-5EB4-43A0-AEA3-35F65280F91B")]
[NativeTypeName("struct IDCompositionVisualDebug : IDCompositionVisual2")]
[NativeInheritance("IDCompositionVisual2")]
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct IDCompositionVisualDebug : IDCompositionVisualDebug.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, uint>)(lpVtbl[1]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, uint>)(lpVtbl[2]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOffsetX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOffsetX(float offsetX)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, float, int>)(lpVtbl[4]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), offsetX);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOffsetY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetOffsetY(float offsetY)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, float, int>)(lpVtbl[6]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), offsetY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTransform(IDCompositionTransform* transform)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionTransform*, int>)(lpVtbl[7]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), transform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransform([NativeTypeName("const D2D_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* matrix)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[8]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), matrix);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTransformParent(IDCompositionVisual* visual)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEffect(IDCompositionEffect* effect)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), effect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetBitmapInterpolationMode(DCOMPOSITION_BITMAP_INTERPOLATION_MODE interpolationMode)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int>)(lpVtbl[11]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), interpolationMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetBorderMode(DCOMPOSITION_BORDER_MODE borderMode)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_BORDER_MODE, int>)(lpVtbl[12]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), borderMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetClip(IDCompositionClip* clip)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionClip*, int>)(lpVtbl[13]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), clip);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetClip([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* rect)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, D2D_RECT_F*, int>)(lpVtbl[14]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), rect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetContent(IUnknown* content)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), content);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddVisual(IDCompositionVisual* visual, BOOL insertAbove, IDCompositionVisual* referenceVisual)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionVisual*, BOOL, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RemoveVisual(IDCompositionVisual* visual)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveAllVisuals()
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, int>)(lpVtbl[18]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetCompositeMode(DCOMPOSITION_COMPOSITE_MODE compositeMode)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_COMPOSITE_MODE, int>)(lpVtbl[19]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), compositeMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetOpacityMode(DCOMPOSITION_OPACITY_MODE mode)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_OPACITY_MODE, int>)(lpVtbl[20]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetBackFaceVisibility(DCOMPOSITION_BACKFACE_VISIBILITY visibility)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_BACKFACE_VISIBILITY, int>)(lpVtbl[21]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), visibility);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, DXGI_RGBA*, int>)(lpVtbl[22]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this), color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT DisableHeatMap()
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, int>)(lpVtbl[23]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT EnableRedrawRegions()
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, int>)(lpVtbl[24]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT DisableRedrawRegions()
    {
        return ((delegate* unmanaged<IDCompositionVisualDebug*, int>)(lpVtbl[25]))((IDCompositionVisualDebug*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDCompositionVisual2.Interface
    {
        [VtblIndex(22)]
        HRESULT EnableHeatMap([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color);

        [VtblIndex(23)]
        HRESULT DisableHeatMap();

        [VtblIndex(24)]
        HRESULT EnableRedrawRegions();

        [VtblIndex(25)]
        HRESULT DisableRedrawRegions();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, uint> Release;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionAnimation*, int> SetOffsetX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, float, int> SetOffsetX1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionAnimation*, int> SetOffsetY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, float, int> SetOffsetY1;

        [NativeTypeName("HRESULT (IDCompositionTransform *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionTransform*, int> SetTransform;

        [NativeTypeName("HRESULT (const D2D_MATRIX_3X2_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, D2D_MATRIX_3X2_F*, int> SetTransform1;

        [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionVisual*, int> SetTransformParent;

        [NativeTypeName("HRESULT (IDCompositionEffect *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionEffect*, int> SetEffect;

        [NativeTypeName("HRESULT (DCOMPOSITION_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_BITMAP_INTERPOLATION_MODE, int> SetBitmapInterpolationMode;

        [NativeTypeName("HRESULT (DCOMPOSITION_BORDER_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_BORDER_MODE, int> SetBorderMode;

        [NativeTypeName("HRESULT (IDCompositionClip *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionClip*, int> SetClip;

        [NativeTypeName("HRESULT (const D2D_RECT_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, D2D_RECT_F*, int> SetClip1;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IUnknown*, int> SetContent;

        [NativeTypeName("HRESULT (IDCompositionVisual *, BOOL, IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionVisual*, BOOL, IDCompositionVisual*, int> AddVisual;

        [NativeTypeName("HRESULT (IDCompositionVisual *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, IDCompositionVisual*, int> RemoveVisual;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, int> RemoveAllVisuals;

        [NativeTypeName("HRESULT (DCOMPOSITION_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_COMPOSITE_MODE, int> SetCompositeMode;

        [NativeTypeName("HRESULT (DCOMPOSITION_OPACITY_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_OPACITY_MODE, int> SetOpacityMode;

        [NativeTypeName("HRESULT (DCOMPOSITION_BACKFACE_VISIBILITY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, DCOMPOSITION_BACKFACE_VISIBILITY, int> SetBackFaceVisibility;

        [NativeTypeName("HRESULT (const D2D1_COLOR_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, DXGI_RGBA*, int> EnableHeatMap;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, int> DisableHeatMap;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, int> EnableRedrawRegions;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionVisualDebug*, int> DisableRedrawRegions;
    }
}
