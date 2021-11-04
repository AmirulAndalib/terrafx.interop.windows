// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9DBE4C0D-3572-4DD9-9825-5530813BB712")]
    [NativeTypeName("struct ID2D1SvgPointCollection : ID2D1SvgAttribute")]
    [NativeInheritance("ID2D1SvgAttribute")]
    public unsafe partial struct ID2D1SvgPointCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, uint>)(lpVtbl[1]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, uint>)(lpVtbl[2]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1SvgPointCollection*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void GetElement(ID2D1SvgElement** element)
        {
            ((delegate* unmanaged<ID2D1SvgPointCollection*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Clone(ID2D1SvgAttribute** attribute)
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), attribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemovePointsAtEnd([NativeTypeName("UINT32")] uint pointsCount)
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, uint, int>)(lpVtbl[6]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), pointsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UpdatePoints([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, D2D_POINT_2F*, uint, uint, int>)(lpVtbl[7]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), points, pointsCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPoints([NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, D2D_POINT_2F*, uint, uint, int>)(lpVtbl[8]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this), points, pointsCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("UINT32")]
        public uint GetPointsCount()
        {
            return ((delegate* unmanaged<ID2D1SvgPointCollection*, uint>)(lpVtbl[9]))((ID2D1SvgPointCollection*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, ID2D1SvgElement**, void> GetElement;

            [NativeTypeName("HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, ID2D1SvgAttribute**, int> Clone;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, uint, int> RemovePointsAtEnd;

            [NativeTypeName("HRESULT (const D2D1_POINT_2F *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, D2D_POINT_2F*, uint, uint, int> UpdatePoints;

            [NativeTypeName("HRESULT (D2D1_POINT_2F *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, D2D_POINT_2F*, uint, uint, int> GetPoints;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1SvgPointCollection*, uint> GetPointsCount;
        }
    }
}
