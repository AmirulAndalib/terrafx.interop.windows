// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("EC446FE8-BFEC-4C64-AB4F-49F038F0C6D2")]
    [NativeTypeName("struct IAppxBundleWriter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleWriter : IAppxBundleWriter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, uint>)(lpVtbl[1]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, uint>)(lpVtbl[2]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream)
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, ushort*, IStream*, int>)(lpVtbl[3]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this), fileName, packageStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IAppxBundleWriter*, int>)(lpVtbl[4]))((IAppxBundleWriter*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream);

            [VtblIndex(4)]
            HRESULT Close();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter*, ushort*, IStream*, int> AddPayloadPackage;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter*, int> Close;
        }
    }
}
