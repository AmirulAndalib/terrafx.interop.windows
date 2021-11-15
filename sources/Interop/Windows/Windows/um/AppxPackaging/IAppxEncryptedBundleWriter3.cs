// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0")]
    [Guid("0D34DEB3-5CAE-4DD3-977C-504932A51D31")]
    [NativeTypeName("struct IAppxEncryptedBundleWriter3 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptedBundleWriter3 : IAppxEncryptedBundleWriter3.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, uint>)(lpVtbl[1]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, uint>)(lpVtbl[2]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPayloadPackageEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream, BOOL isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, ushort*, IStream*, BOOL, int>)(lpVtbl[3]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this), fileName, packageStream, isDefaultApplicablePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, ushort*, IStream*, BOOL, int>)(lpVtbl[4]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddPayloadPackageEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream, BOOL isDefaultApplicablePackage);

            [VtblIndex(4)]
            HRESULT AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedBundleWriter3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedBundleWriter3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedBundleWriter3*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedBundleWriter3*, ushort*, IStream*, BOOL, int> AddPayloadPackageEncrypted;

            [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptedBundleWriter3*, ushort*, IStream*, BOOL, int> AddExternalPackageReference;
        }
    }
}