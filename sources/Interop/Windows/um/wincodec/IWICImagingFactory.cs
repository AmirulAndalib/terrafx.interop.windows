// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC5EC8A9-C395-4314-9C77-54D7A935FF70")]
    [NativeTypeName("struct IWICImagingFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICImagingFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICImagingFactory*, uint>)(lpVtbl[1]))((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICImagingFactory*, uint>)(lpVtbl[2]))((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)(lpVtbl[6]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreatePalette(IWICPalette** ppIPalette)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICPalette**, int>)(lpVtbl[9]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICFormatConverter**, int>)(lpVtbl[10]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateStream(IWICStream** ppIWICStream)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICStream**, int>)(lpVtbl[14]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CreateColorContext(IWICColorContext** ppIWICColorContext)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICColorContext**, int>)(lpVtbl[15]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICColorTransform**, int>)(lpVtbl[16]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CreateBitmap(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[17]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[18]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)(lpVtbl[19]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT CreateBitmapFromMemory(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)(lpVtbl[20]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CreateBitmapFromHBITMAP(HBITMAP hBitmap, HPALETTE hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap**, int>)(lpVtbl[21]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT CreateBitmapFromHICON(HICON hIcon, IWICBitmap** ppIBitmap)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, HICON, IWICBitmap**, int>)(lpVtbl[22]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, uint, uint, IEnumUnknown**, int>)(lpVtbl[23]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return ((delegate* unmanaged<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, ushort*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFilename;

            [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromStream;

            [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFileHandle;

            [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, Guid*, IWICComponentInfo**, int> CreateComponentInfo;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int> CreateDecoder;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int> CreateEncoder;

            [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICPalette**, int> CreatePalette;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICFormatConverter**, int> CreateFormatConverter;

            [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICBitmapScaler**, int> CreateBitmapScaler;

            [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICBitmapClipper**, int> CreateBitmapClipper;

            [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICBitmapFlipRotator**, int> CreateBitmapFlipRotator;

            [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICStream**, int> CreateStream;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICColorContext**, int> CreateColorContext;

            [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICColorTransform**, int> CreateColorTransformer;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmapFromSource;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int> CreateBitmapFromSourceRect;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int> CreateBitmapFromMemory;

            [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap**, int> CreateBitmapFromHBITMAP;

            [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, HICON, IWICBitmap**, int> CreateBitmapFromHICON;

            [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, uint, uint, IEnumUnknown**, int> CreateComponentEnumerator;

            [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromDecoder;

            [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromFrameDecode;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriter;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromReader;
        }
    }
}
