// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
[NativeTypeName("struct IDXGIFactoryMedia : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct IDXGIFactoryMedia : IDXGIFactoryMedia.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIFactoryMedia*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIFactoryMedia*, uint>)(lpVtbl[1]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIFactoryMedia*, uint>)(lpVtbl[2]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, HANDLE hSurface, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        return ((delegate* unmanaged<IDXGIFactoryMedia*, IUnknown*, HANDLE, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[3]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, HANDLE hSurface, DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        return ((delegate* unmanaged<IDXGIFactoryMedia*, IUnknown*, HANDLE, DXGI_DECODE_SWAP_CHAIN_DESC*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)(lpVtbl[4]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, HANDLE hSurface, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [VtblIndex(4)]
        HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, HANDLE hSurface, DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain);
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

        [NativeTypeName("HRESULT (IUnknown *, HANDLE, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, HANDLE, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForCompositionSurfaceHandle;

        [NativeTypeName("HRESULT (IUnknown *, HANDLE, DXGI_DECODE_SWAP_CHAIN_DESC *, IDXGIResource *, IDXGIOutput *, IDXGIDecodeSwapChain **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, HANDLE, DXGI_DECODE_SWAP_CHAIN_DESC*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int> CreateDecodeSwapChainForCompositionSurfaceHandle;
    }
}
