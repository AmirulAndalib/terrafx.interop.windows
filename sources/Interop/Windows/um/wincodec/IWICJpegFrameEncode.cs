// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1")]
    [NativeTypeName("struct IWICJpegFrameEncode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICJpegFrameEncode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICJpegFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICJpegFrameEncode*, uint>)(lpVtbl[1]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICJpegFrameEncode*, uint>)(lpVtbl[2]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return ((delegate* unmanaged<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int>)(lpVtbl[3]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return ((delegate* unmanaged<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int>)(lpVtbl[4]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetQuantizationTable(uint scanIndex, uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return ((delegate* unmanaged<IWICJpegFrameEncode*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int>)(lpVtbl[5]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT WriteScan(uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData)
        {
            return ((delegate* unmanaged<IWICJpegFrameEncode*, uint, byte*, int>)(lpVtbl[6]))((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), cbScanData, pbScanData);
        }
    }
}
