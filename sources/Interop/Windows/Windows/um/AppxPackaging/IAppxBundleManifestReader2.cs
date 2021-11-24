// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("5517DF70-033F-4AF2-8213-87D766805C02")]
[NativeTypeName("struct IAppxBundleManifestReader2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleManifestReader2 : IAppxBundleManifestReader2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, uint>)(lpVtbl[1]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, uint>)(lpVtbl[2]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOptionalBundles(IAppxBundleManifestOptionalBundleInfoEnumerator** optionalBundles)
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader2*, IAppxBundleManifestOptionalBundleInfoEnumerator**, int>)(lpVtbl[3]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this), optionalBundles);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOptionalBundles(IAppxBundleManifestOptionalBundleInfoEnumerator** optionalBundles);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestReader2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestReader2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestReader2*, uint> Release;

        [NativeTypeName("HRESULT (IAppxBundleManifestOptionalBundleInfoEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxBundleManifestReader2*, IAppxBundleManifestOptionalBundleInfoEnumerator**, int> GetOptionalBundles;
    }
}
