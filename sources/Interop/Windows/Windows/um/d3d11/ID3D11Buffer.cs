// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("48570B85-D1EE-4FCD-A250-EB350722B037")]
    [NativeTypeName("struct ID3D11Buffer : ID3D11Resource")]
    [NativeInheritance("ID3D11Resource")]
    public unsafe partial struct ID3D11Buffer : ID3D11Buffer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Buffer*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Buffer*, uint>)(lpVtbl[1]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Buffer*, uint>)(lpVtbl[2]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11Buffer*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11Buffer*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11Buffer*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11Buffer*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetType(D3D11_RESOURCE_DIMENSION* pResourceDimension)
        {
            ((delegate* unmanaged<ID3D11Buffer*, D3D11_RESOURCE_DIMENSION*, void>)(lpVtbl[7]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), pResourceDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void SetEvictionPriority(uint EvictionPriority)
        {
            ((delegate* unmanaged<ID3D11Buffer*, uint, void>)(lpVtbl[8]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public uint GetEvictionPriority()
        {
            return ((delegate* unmanaged<ID3D11Buffer*, uint>)(lpVtbl[9]))((ID3D11Buffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void GetDesc(D3D11_BUFFER_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D11Buffer*, D3D11_BUFFER_DESC*, void>)(lpVtbl[10]))((ID3D11Buffer*)Unsafe.AsPointer(ref this), pDesc);
        }

        public interface Interface : ID3D11Resource.Interface
        {
            [VtblIndex(10)]
            void GetDesc(D3D11_BUFFER_DESC* pDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, uint> Release;

            [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, ID3D11Device**, void> GetDevice;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("void (D3D11_RESOURCE_DIMENSION *) __attribute__((stdcall))")]
            public new delegate* unmanaged<ID3D11Buffer*, D3D11_RESOURCE_DIMENSION*, void> GetType;

            [NativeTypeName("void (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, uint, void> SetEvictionPriority;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, uint> GetEvictionPriority;

            [NativeTypeName("void (D3D11_BUFFER_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11Buffer*, D3D11_BUFFER_DESC*, void> GetDesc;
        }
    }
}
