// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("DC102F47-A12D-4B1C-822D-9E117E33043F")]
    [NativeTypeName("struct IDWriteInMemoryFontFileLoader : IDWriteFontFileLoader")]
    [NativeInheritance("IDWriteFontFileLoader")]
    public unsafe partial struct IDWriteInMemoryFontFileLoader : IDWriteInMemoryFontFileLoader.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint>)(lpVtbl[1]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint>)(lpVtbl[2]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[3]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateInMemoryFontFileReference(IDWriteFactory* factory, [NativeTypeName("const void *")] void* fontData, [NativeTypeName("UINT32")] uint fontDataSize, IUnknown* ownerObject, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, IUnknown*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), factory, fontData, fontDataSize, ownerObject, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        public uint GetFileCount()
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint>)(lpVtbl[5]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IDWriteFontFileLoader.Interface
        {
            [VtblIndex(4)]
            HRESULT CreateInMemoryFontFileReference(IDWriteFactory* factory, [NativeTypeName("const void *")] void* fontData, [NativeTypeName("UINT32")] uint fontDataSize, IUnknown* ownerObject, IDWriteFontFile** fontFile);

            [VtblIndex(5)]
            [return: NativeTypeName("UINT32")]
            uint GetFileCount();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteInMemoryFontFileLoader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint> Release;

            [NativeTypeName("HRESULT (const void *, UINT32, IDWriteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int> CreateStreamFromKey;

            [NativeTypeName("HRESULT (IDWriteFactory *, const void *, UINT32, IUnknown *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, IUnknown*, IDWriteFontFile**, int> CreateInMemoryFontFileReference;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint> GetFileCount;
        }
    }
}
