// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("DF0C7CEC-CDEB-4D4A-B91C-721BF22F4E6C")]
    [NativeTypeName("struct IDCompositionInkTrailDevice : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDCompositionInkTrailDevice : IDCompositionInkTrailDevice.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, uint>)(lpVtbl[1]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, uint>)(lpVtbl[2]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail)
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[3]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), inkTrail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateDelegatedInkTrailForSwapChain(IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail)
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, IUnknown*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[4]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), swapChain, inkTrail);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail);

            [VtblIndex(4)]
            HRESULT CreateDelegatedInkTrailForSwapChain(IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionInkTrailDevice*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionInkTrailDevice*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionInkTrailDevice*, uint> Release;

            [NativeTypeName("HRESULT (IDCompositionDelegatedInkTrail **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int> CreateDelegatedInkTrail;

            [NativeTypeName("HRESULT (IUnknown *, IDCompositionDelegatedInkTrail **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDCompositionInkTrailDevice*, IUnknown*, IDCompositionDelegatedInkTrail**, int> CreateDelegatedInkTrailForSwapChain;
        }
    }
}