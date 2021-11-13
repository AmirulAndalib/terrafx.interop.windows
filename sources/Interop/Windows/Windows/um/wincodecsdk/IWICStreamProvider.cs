// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("449494BC-B468-4927-96D7-BA90D31AB505")]
    [NativeTypeName("struct IWICStreamProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICStreamProvider : IWICStreamProvider.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICStreamProvider*, Guid*, void**, int>)(lpVtbl[0]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICStreamProvider*, uint>)(lpVtbl[1]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICStreamProvider*, uint>)(lpVtbl[2]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetStream(IStream** ppIStream)
        {
            return ((delegate* unmanaged<IWICStreamProvider*, IStream**, int>)(lpVtbl[3]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), ppIStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions)
        {
            return ((delegate* unmanaged<IWICStreamProvider*, uint*, int>)(lpVtbl[4]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), pdwPersistOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPreferredVendorGUID(Guid* pguidPreferredVendor)
        {
            return ((delegate* unmanaged<IWICStreamProvider*, Guid*, int>)(lpVtbl[5]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), pguidPreferredVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RefreshStream()
        {
            return ((delegate* unmanaged<IWICStreamProvider*, int>)(lpVtbl[6]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetStream(IStream** ppIStream);

            [VtblIndex(4)]
            HRESULT GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions);

            [VtblIndex(5)]
            HRESULT GetPreferredVendorGUID(Guid* pguidPreferredVendor);

            [VtblIndex(6)]
            HRESULT RefreshStream();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICStreamProvider*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICStreamProvider*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICStreamProvider*, uint> Release;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICStreamProvider*, IStream**, int> GetStream;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICStreamProvider*, uint*, int> GetPersistOptions;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICStreamProvider*, Guid*, int> GetPreferredVendorGUID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICStreamProvider*, int> RefreshStream;
        }
    }
}
