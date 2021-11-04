// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F43D0B0B-1379-40E2-9B29-682EA2BF42AF")]
    [NativeTypeName("struct IAppxEncryptedPackageWriter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptedPackageWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, uint>)(lpVtbl[1]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, uint>)(lpVtbl[2]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPayloadFileEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, APPX_COMPRESSION_OPTION compressionOption, IStream* inputStream)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int>)(lpVtbl[3]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this), fileName, compressionOption, inputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, int>)(lpVtbl[4]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, APPX_COMPRESSION_OPTION, IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int> AddPayloadFileEncrypted;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter*, int> Close;
        }
    }
}
