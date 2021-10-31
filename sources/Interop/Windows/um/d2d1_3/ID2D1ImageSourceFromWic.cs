// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
    [NativeTypeName("struct ID2D1ImageSourceFromWic : ID2D1ImageSource")]
    [NativeInheritance("ID2D1ImageSource")]
    public unsafe partial struct ID2D1ImageSourceFromWic
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, uint>)(lpVtbl[1]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, uint>)(lpVtbl[2]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1ImageSourceFromWic*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OfferResources()
        {
            return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, int>)(lpVtbl[4]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT TryReclaimResources(BOOL* resourcesDiscarded)
        {
            return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, BOOL*, int>)(lpVtbl[5]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), resourcesDiscarded);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnsureCached([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill)
        {
            return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, D2D_RECT_U*, int>)(lpVtbl[6]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToFill);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT TrimCache([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve)
        {
            return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, D2D_RECT_U*, int>)(lpVtbl[7]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToPreserve);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetSource(IWICBitmapSource** wicBitmapSource)
        {
            ((delegate* unmanaged<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void>)(lpVtbl[8]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), wicBitmapSource);
        }
    }
}
