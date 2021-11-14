// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("5C1E0D8A-7C23-48F9-8C59-A92958CEFF11")]
    [NativeTypeName("struct ID3DDeviceContextState : ID3D11DeviceChild")]
    [NativeInheritance("ID3D11DeviceChild")]
    public unsafe partial struct ID3DDeviceContextState : ID3DDeviceContextState.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3DDeviceContextState*, Guid*, void**, int>)(lpVtbl[0]))((ID3DDeviceContextState*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3DDeviceContextState*, uint>)(lpVtbl[1]))((ID3DDeviceContextState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3DDeviceContextState*, uint>)(lpVtbl[2]))((ID3DDeviceContextState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3DDeviceContextState*, ID3D11Device**, void>)(lpVtbl[3]))((ID3DDeviceContextState*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3DDeviceContextState*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3DDeviceContextState*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3DDeviceContextState*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3DDeviceContextState*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3DDeviceContextState*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3DDeviceContextState*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public interface Interface : ID3D11DeviceChild.Interface
        {
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DDeviceContextState*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DDeviceContextState*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DDeviceContextState*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DDeviceContextState*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DDeviceContextState*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DDeviceContextState*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DDeviceContextState*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        }
    }
}
