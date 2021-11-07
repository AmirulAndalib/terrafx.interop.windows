// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.18362.0")]
    [Guid("BDB64DF4-EA2F-4C70-B861-AAAB1258BB5D")]
    [NativeTypeName("struct ID3D11On12Device1 : ID3D11On12Device")]
    [NativeInheritance("ID3D11On12Device")]
    public unsafe partial struct ID3D11On12Device1 : ID3D11On12Device1.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11On12Device1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11On12Device1*, uint>)(lpVtbl[1]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11On12Device1*, uint>)(lpVtbl[2]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateWrappedResource(IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, void** ppResource11)
        {
            return ((delegate* unmanaged<ID3D11On12Device1*, IUnknown*, D3D11_RESOURCE_FLAGS*, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, Guid*, void**, int>)(lpVtbl[3]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, uint NumResources)
        {
            ((delegate* unmanaged<ID3D11On12Device1*, ID3D11Resource**, uint, void>)(lpVtbl[4]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, uint NumResources)
        {
            ((delegate* unmanaged<ID3D11On12Device1*, ID3D11Resource**, uint, void>)(lpVtbl[5]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D11On12Device1*, Guid*, void**, int>)(lpVtbl[6]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public interface Interface : ID3D11On12Device.Interface
        {
            [VtblIndex(6)]
            HRESULT GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11On12Device1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11On12Device1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11On12Device1*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, const D3D11_RESOURCE_FLAGS *, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11On12Device1*, IUnknown*, D3D11_RESOURCE_FLAGS*, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, Guid*, void**, int> CreateWrappedResource;

            [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11On12Device1*, ID3D11Resource**, uint, void> ReleaseWrappedResources;

            [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11On12Device1*, ID3D11Resource**, uint, void> AcquireWrappedResources;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11On12Device1*, Guid*, void**, int> GetD3D12Device;
        }
    }
}
