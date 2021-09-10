// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C095E4F4-BB98-43D6-9745-4D1B84EC9888")]
    [NativeTypeName("struct ID2D1SvgPathData : ID2D1SvgAttribute")]
    [NativeInheritance("ID2D1SvgAttribute")]
    public unsafe partial struct ID2D1SvgPathData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, uint>)(lpVtbl[1]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, uint>)(lpVtbl[2]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1SvgPathData*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void GetElement(ID2D1SvgElement** element)
        {
            ((delegate* unmanaged<ID2D1SvgPathData*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ID2D1SvgAttribute** attribute)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), attribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentDataAtEnd([NativeTypeName("UINT32")] uint dataCount)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, uint, int>)(lpVtbl[6]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), dataCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateSegmentData([NativeTypeName("const FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, float*, uint, uint, int>)(lpVtbl[7]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetSegmentData([NativeTypeName("FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, float*, uint, uint, int>)(lpVtbl[8]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("UINT32")]
        public uint GetSegmentDataCount()
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, uint>)(lpVtbl[9]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveCommandsAtEnd([NativeTypeName("UINT32")] uint commandsCount)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, uint, int>)(lpVtbl[10]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commandsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateCommands([NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int>)(lpVtbl[11]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetCommands(D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int>)(lpVtbl[12]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("UINT32")]
        public uint GetCommandsCount()
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, uint>)(lpVtbl[13]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(D2D1_FILL_MODE fillMode, ID2D1PathGeometry1** pathGeometry)
        {
            return ((delegate* unmanaged<ID2D1SvgPathData*, D2D1_FILL_MODE, ID2D1PathGeometry1**, int>)(lpVtbl[14]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), fillMode, pathGeometry);
        }
    }
}
