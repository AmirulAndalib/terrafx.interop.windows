// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9B856EE-49A6-4E19-B2B0-6A2406D63A32")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfoEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfoEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrent(IAppxBundleManifestPackageInfo** packageInfo)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, IAppxBundleManifestPackageInfo**, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), packageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint> Release;

            [NativeTypeName("HRESULT (IAppxBundleManifestPackageInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, IAppxBundleManifestPackageInfo**, int> GetCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, BOOL*, int> GetHasCurrent;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, BOOL*, int> MoveNext;
        }
    }
}
