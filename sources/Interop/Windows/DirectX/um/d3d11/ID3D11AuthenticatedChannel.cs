// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("3015A308-DCBD-47AA-A747-192486D14D4A")]
[NativeTypeName("struct ID3D11AuthenticatedChannel : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct ID3D11AuthenticatedChannel : ID3D11AuthenticatedChannel.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[1]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[2]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11AuthenticatedChannel*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), ppDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCertificateSize(uint* pCertificateSize)
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint*, int>)(lpVtbl[7]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pCertificateSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCertificate(uint CertificateSize, byte* pCertificate)
    {
        return ((delegate* unmanaged<ID3D11AuthenticatedChannel*, uint, byte*, int>)(lpVtbl[8]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetChannelHandle(HANDLE* pChannelHandle)
    {
        ((delegate* unmanaged<ID3D11AuthenticatedChannel*, HANDLE*, void>)(lpVtbl[9]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pChannelHandle);
    }

    public interface Interface : ID3D11DeviceChild.Interface
    {
        [VtblIndex(7)]
        HRESULT GetCertificateSize(uint* pCertificateSize);

        [VtblIndex(8)]
        HRESULT GetCertificate(uint CertificateSize, byte* pCertificate);

        [VtblIndex(9)]
        void GetChannelHandle(HANDLE* pChannelHandle);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCertificateSize;

        [NativeTypeName("HRESULT (UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> GetCertificate;

        [NativeTypeName("void (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, void> GetChannelHandle;
    }
}
