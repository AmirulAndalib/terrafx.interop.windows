// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E0DB51C3-6F77-4BAE-B3D5-E47509B35838")]
    [NativeTypeName("struct ID2D1GdiInteropRenderTarget : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID2D1GdiInteropRenderTarget
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget*, uint>)(lpVtbl[1]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget*, uint>)(lpVtbl[2]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDC(D2D1_DC_INITIALIZE_MODE mode, HDC* hdc)
        {
            return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget*, D2D1_DC_INITIALIZE_MODE, HDC*, int>)(lpVtbl[3]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), mode, hdc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ReleaseDC([NativeTypeName("const RECT *")] RECT* update)
        {
            return ((delegate* unmanaged<ID2D1GdiInteropRenderTarget*, RECT*, int>)(lpVtbl[4]))((ID2D1GdiInteropRenderTarget*)Unsafe.AsPointer(ref this), update);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GdiInteropRenderTarget*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GdiInteropRenderTarget*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GdiInteropRenderTarget*, uint> Release;

            [NativeTypeName("HRESULT (D2D1_DC_INITIALIZE_MODE, HDC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GdiInteropRenderTarget*, D2D1_DC_INITIALIZE_MODE, HDC*, int> GetDC;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1GdiInteropRenderTarget*, RECT*, int> ReleaseDC;
        }
    }
}
