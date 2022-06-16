// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3"]/*' />
[Guid("DA044E00-69B2-11D0-A1D5-00AA00B8DFBB")]
[NativeTypeName("struct IDirectDrawSurface3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawSurface3 : IDirectDrawSurface3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawSurface3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint>)(lpVtbl[1]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint>)(lpVtbl[2]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.AddAttachedSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawSurface3*, int>)(lpVtbl[3]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.AddOverlayDirtyRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, int>)(lpVtbl[4]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.Blt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDBLTFX*, int>)(lpVtbl[5]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.BltBatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, DDBLTBATCH*, uint, uint, int>)(lpVtbl[6]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.BltFast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, uint, IDirectDrawSurface3*, RECT*, uint, int>)(lpVtbl[7]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.DeleteAttachedSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, IDirectDrawSurface3*, int>)(lpVtbl[8]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.EnumAttachedSurfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumAttachedSurfaces([NativeTypeName("LPVOID")] void* param0, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT> param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[9]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.EnumOverlayZOrders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumOverlayZOrders([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("LPDDENUMSURFACESCALLBACK")] delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT> param2)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int>)(lpVtbl[10]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.Flip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Flip([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawSurface3*, uint, int>)(lpVtbl[11]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetAttachedSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAttachedSurface([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3 *")] IDirectDrawSurface3** param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, DDSCAPS*, IDirectDrawSurface3**, int>)(lpVtbl[12]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetBltStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBltStatus([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[13]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCaps([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, DDSCAPS*, int>)(lpVtbl[14]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetClipper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawClipper**, int>)(lpVtbl[15]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, DDCOLORKEY*, int>)(lpVtbl[16]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetDC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDC(HDC* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, HDC*, int>)(lpVtbl[17]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetFlipStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFlipStatus([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[18]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetOverlayPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, int*, int*, int>)(lpVtbl[19]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawPalette**, int>)(lpVtbl[20]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetPixelFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, DDPIXELFORMAT*, int>)(lpVtbl[21]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetSurfaceDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, DDSURFACEDESC*, int>)(lpVtbl[22]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDraw*, DDSURFACEDESC*, int>)(lpVtbl[23]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.IsLost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT IsLost()
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, int>)(lpVtbl[24]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.Lock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("DWORD")] uint param2, HANDLE param3)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, DDSURFACEDESC*, uint, HANDLE, int>)(lpVtbl[25]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.ReleaseDC"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ReleaseDC(HDC param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, HDC, int>)(lpVtbl[26]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.Restore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Restore()
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, int>)(lpVtbl[27]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.SetClipper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawClipper*, int>)(lpVtbl[28]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.SetColorKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, DDCOLORKEY*, int>)(lpVtbl[29]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.SetOverlayPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, int, int, int>)(lpVtbl[30]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.SetPalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, IDirectDrawPalette*, int>)(lpVtbl[31]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.Unlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT Unlock([NativeTypeName("LPVOID")] void* param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, void*, int>)(lpVtbl[32]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.UpdateOverlay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDOVERLAYFX*, int>)(lpVtbl[33]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.UpdateOverlayDisplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[34]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.UpdateOverlayZOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, IDirectDrawSurface3*, int>)(lpVtbl[35]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.GetDDInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetDDInterface([NativeTypeName("LPVOID *")] void** param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, void**, int>)(lpVtbl[36]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.PageLock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT PageLock([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[37]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.PageUnlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT PageUnlock([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, uint, int>)(lpVtbl[38]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawSurface3.xml' path='doc/member[@name="IDirectDrawSurface3.SetSurfaceDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawSurface3*, DDSURFACEDESC*, uint, int>)(lpVtbl[39]))((IDirectDrawSurface3*)Unsafe.AsPointer(ref this), param0, param1);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddAttachedSurface([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0);

        [VtblIndex(4)]
        HRESULT AddOverlayDirtyRect([NativeTypeName("LPRECT")] RECT* param0);

        [VtblIndex(5)]
        HRESULT Blt([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDBLTFX")] DDBLTFX* param4);

        [VtblIndex(6)]
        HRESULT BltBatch([NativeTypeName("LPDDBLTBATCH")] DDBLTBATCH* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(7)]
        HRESULT BltFast([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param2, [NativeTypeName("LPRECT")] RECT* param3, [NativeTypeName("DWORD")] uint param4);

        [VtblIndex(8)]
        HRESULT DeleteAttachedSurface([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1);

        [VtblIndex(11)]
        HRESULT Flip([NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(12)]
        HRESULT GetAttachedSurface([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3 *")] IDirectDrawSurface3** param1);

        [VtblIndex(13)]
        HRESULT GetBltStatus([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(14)]
        HRESULT GetCaps([NativeTypeName("LPDDSCAPS")] DDSCAPS* param0);

        [VtblIndex(15)]
        HRESULT GetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** param0);

        [VtblIndex(16)]
        HRESULT GetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1);

        [VtblIndex(17)]
        HRESULT GetDC(HDC* param0);

        [VtblIndex(18)]
        HRESULT GetFlipStatus([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(19)]
        HRESULT GetOverlayPosition([NativeTypeName("LPLONG")] int* param0, [NativeTypeName("LPLONG")] int* param1);

        [VtblIndex(20)]
        HRESULT GetPalette([NativeTypeName("LPDIRECTDRAWPALETTE *")] IDirectDrawPalette** param0);

        [VtblIndex(21)]
        HRESULT GetPixelFormat([NativeTypeName("LPDDPIXELFORMAT")] DDPIXELFORMAT* param0);

        [VtblIndex(22)]
        HRESULT GetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0);

        [VtblIndex(23)]
        HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1);

        [VtblIndex(24)]
        HRESULT IsLost();

        [VtblIndex(25)]
        HRESULT Lock([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param1, [NativeTypeName("DWORD")] uint param2, HANDLE param3);

        [VtblIndex(26)]
        HRESULT ReleaseDC(HDC param0);

        [VtblIndex(27)]
        HRESULT Restore();

        [VtblIndex(28)]
        HRESULT SetClipper([NativeTypeName("LPDIRECTDRAWCLIPPER")] IDirectDrawClipper* param0);

        [VtblIndex(29)]
        HRESULT SetColorKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDCOLORKEY")] DDCOLORKEY* param1);

        [VtblIndex(30)]
        HRESULT SetOverlayPosition([NativeTypeName("LONG")] int param0, [NativeTypeName("LONG")] int param1);

        [VtblIndex(31)]
        HRESULT SetPalette([NativeTypeName("LPDIRECTDRAWPALETTE")] IDirectDrawPalette* param0);

        [VtblIndex(32)]
        HRESULT Unlock([NativeTypeName("LPVOID")] void* param0);

        [VtblIndex(33)]
        HRESULT UpdateOverlay([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPDDOVERLAYFX")] DDOVERLAYFX* param4);

        [VtblIndex(34)]
        HRESULT UpdateOverlayDisplay([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(35)]
        HRESULT UpdateOverlayZOrder([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIRECTDRAWSURFACE3")] IDirectDrawSurface3* param1);

        [VtblIndex(36)]
        HRESULT GetDDInterface([NativeTypeName("LPVOID *")] void** param0);

        [VtblIndex(37)]
        HRESULT PageLock([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(38)]
        HRESULT PageUnlock([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(39)]
        HRESULT SetSurfaceDesc([NativeTypeName("LPDDSURFACEDESC")] DDSURFACEDESC* param0, [NativeTypeName("DWORD")] uint param1);
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

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE3) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface3*, int> AddAttachedSurface;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> AddOverlayDirtyRect;

        [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE3, LPRECT, DWORD, LPDDBLTFX) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDBLTFX*, int> Blt;

        [NativeTypeName("HRESULT (LPDDBLTBATCH, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDBLTBATCH*, uint, uint, int> BltBatch;

        [NativeTypeName("HRESULT (DWORD, DWORD, LPDIRECTDRAWSURFACE3, LPRECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IDirectDrawSurface3*, RECT*, uint, int> BltFast;

        [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE3) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDirectDrawSurface3*, int> DeleteAttachedSurface;

        [NativeTypeName("HRESULT (LPVOID, LPDDENUMSURFACESCALLBACK) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int> EnumAttachedSurfaces;

        [NativeTypeName("HRESULT (DWORD, LPVOID, LPDDENUMSURFACESCALLBACK) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, delegate* unmanaged<IDirectDrawSurface*, DDSURFACEDESC*, void*, HRESULT>, int> EnumOverlayZOrders;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE3, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface3*, uint, int> Flip;

        [NativeTypeName("HRESULT (LPDDSCAPS, LPDIRECTDRAWSURFACE3 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSCAPS*, IDirectDrawSurface3**, int> GetAttachedSurface;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> GetBltStatus;

        [NativeTypeName("HRESULT (LPDDSCAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSCAPS*, int> GetCaps;

        [NativeTypeName("HRESULT (LPDIRECTDRAWCLIPPER *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawClipper**, int> GetClipper;

        [NativeTypeName("HRESULT (DWORD, LPDDCOLORKEY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDCOLORKEY*, int> GetColorKey;

        [NativeTypeName("HRESULT (HDC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC*, int> GetDC;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> GetFlipStatus;

        [NativeTypeName("HRESULT (LPLONG, LPLONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetOverlayPosition;

        [NativeTypeName("HRESULT (LPDIRECTDRAWPALETTE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawPalette**, int> GetPalette;

        [NativeTypeName("HRESULT (LPDDPIXELFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDPIXELFORMAT*, int> GetPixelFormat;

        [NativeTypeName("HRESULT (LPDDSURFACEDESC) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC*, int> GetSurfaceDesc;

        [NativeTypeName("HRESULT (LPDIRECTDRAW, LPDDSURFACEDESC) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw*, DDSURFACEDESC*, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsLost;

        [NativeTypeName("HRESULT (LPRECT, LPDDSURFACEDESC, DWORD, HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, DDSURFACEDESC*, uint, HANDLE, int> Lock;

        [NativeTypeName("HRESULT (HDC) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, int> ReleaseDC;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Restore;

        [NativeTypeName("HRESULT (LPDIRECTDRAWCLIPPER) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawClipper*, int> SetClipper;

        [NativeTypeName("HRESULT (DWORD, LPDDCOLORKEY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DDCOLORKEY*, int> SetColorKey;

        [NativeTypeName("HRESULT (LONG, LONG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetOverlayPosition;

        [NativeTypeName("HRESULT (LPDIRECTDRAWPALETTE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawPalette*, int> SetPalette;

        [NativeTypeName("HRESULT (LPVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> Unlock;

        [NativeTypeName("HRESULT (LPRECT, LPDIRECTDRAWSURFACE3, LPRECT, DWORD, LPDDOVERLAYFX) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IDirectDrawSurface3*, RECT*, uint, DDOVERLAYFX*, int> UpdateOverlay;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UpdateOverlayDisplay;

        [NativeTypeName("HRESULT (DWORD, LPDIRECTDRAWSURFACE3) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDirectDrawSurface3*, int> UpdateOverlayZOrder;

        [NativeTypeName("HRESULT (LPVOID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void**, int> GetDDInterface;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PageLock;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PageUnlock;

        [NativeTypeName("HRESULT (LPDDSURFACEDESC, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDSURFACEDESC*, uint, int> SetSurfaceDesc;
    }
}
