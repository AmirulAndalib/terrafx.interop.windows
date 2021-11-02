// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2D3BA758-33EE-42D5-BB7B-5F3431D86C78")]
    [NativeTypeName("struct INameSpaceTreeControlCustomDraw : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INameSpaceTreeControlCustomDraw
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, uint>)(lpVtbl[1]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, uint>)(lpVtbl[2]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT PrePaint(HDC hdc, RECT* prc, LRESULT* plres)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, HDC, RECT*, LRESULT*, int>)(lpVtbl[3]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc, plres);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT PostPaint(HDC hdc, RECT* prc)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, HDC, RECT*, int>)(lpVtbl[4]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ItemPrePaint(HDC hdc, RECT* prc, NSTCCUSTOMDRAW* pnstccdItem, COLORREF* pclrText, COLORREF* pclrTextBk, LRESULT* plres)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, HDC, RECT*, NSTCCUSTOMDRAW*, COLORREF*, COLORREF*, LRESULT*, int>)(lpVtbl[5]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc, pnstccdItem, pclrText, pclrTextBk, plres);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ItemPostPaint(HDC hdc, RECT* prc, NSTCCUSTOMDRAW* pnstccdItem)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw*, HDC, RECT*, NSTCCUSTOMDRAW*, int>)(lpVtbl[6]))((INameSpaceTreeControlCustomDraw*)Unsafe.AsPointer(ref this), hdc, prc, pnstccdItem);
        }
    }
}
