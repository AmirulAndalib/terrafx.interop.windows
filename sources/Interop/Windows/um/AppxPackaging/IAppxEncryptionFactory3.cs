// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09EDCA37-CD64-47D6-B7E8-1CB11D4F7E05")]
    [NativeTypeName("struct IAppxEncryptionFactory3 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptionFactory3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptionFactory3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory3*, uint>)(lpVtbl[1]))((IAppxEncryptionFactory3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory3*, uint>)(lpVtbl[2]))((IAppxEncryptionFactory3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT EncryptPackage(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, int>)(lpVtbl[3]))((IAppxEncryptionFactory3*)Unsafe.AsPointer(ref this), inputStream, outputStream, settings, keyInfo, exemptedFiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateEncryptedPackageWriter(IStream* outputStream, IStream* manifestStream, IStream* contentGroupMapStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, IAppxEncryptedPackageWriter** packageWriter)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedPackageWriter**, int>)(lpVtbl[4]))((IAppxEncryptionFactory3*)Unsafe.AsPointer(ref this), outputStream, manifestStream, contentGroupMapStream, settings, keyInfo, exemptedFiles, packageWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EncryptBundle(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, int>)(lpVtbl[5]))((IAppxEncryptionFactory3*)Unsafe.AsPointer(ref this), inputStream, outputStream, settings, keyInfo, exemptedFiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateEncryptedBundleWriter(IStream* outputStream, [NativeTypeName("UINT64")] ulong bundleVersion, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, IAppxEncryptedBundleWriter** bundleWriter)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, ulong, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedBundleWriter**, int>)(lpVtbl[6]))((IAppxEncryptionFactory3*)Unsafe.AsPointer(ref this), outputStream, bundleVersion, settings, keyInfo, exemptedFiles, bundleWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory3*, uint> Release;

            [NativeTypeName("HRESULT (IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, int> EncryptPackage;

            [NativeTypeName("HRESULT (IStream *, IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *, IAppxEncryptedPackageWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedPackageWriter**, int> CreateEncryptedPackageWriter;

            [NativeTypeName("HRESULT (IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, int> EncryptBundle;

            [NativeTypeName("HRESULT (IStream *, UINT64, const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *, IAppxEncryptedBundleWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory3*, IStream*, ulong, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedBundleWriter**, int> CreateEncryptedBundleWriter;
        }
    }
}
