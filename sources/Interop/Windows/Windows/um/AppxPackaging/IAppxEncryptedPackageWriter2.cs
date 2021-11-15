// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.14393.0")]
    [Guid("3E475447-3A25-40B5-8AD2-F953AE50C92D")]
    [NativeTypeName("struct IAppxEncryptedPackageWriter2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptedPackageWriter2 : IAppxEncryptedPackageWriter2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint>)(lpVtbl[1]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint>)(lpVtbl[2]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPayloadFilesEncrypted([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int>)(lpVtbl[3]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this), fileCount, payloadFiles, memoryLimit);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddPayloadFilesEncrypted([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint> Release;

            [NativeTypeName("HRESULT (UINT32, APPX_PACKAGE_WRITER_PAYLOAD_STREAM *, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int> AddPayloadFilesEncrypted;
        }
    }
}