// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10misc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateDevice"]/*' />
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateDevice(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, uint SDKVersion, ID3D10Device** ppDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateDeviceAndSwapChain"]/*' />
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateDeviceAndSwapChain(IDXGIAdapter* pAdapter, D3D10_DRIVER_TYPE DriverType, HMODULE Software, uint Flags, uint SDKVersion, DXGI_SWAP_CHAIN_DESC* pSwapChainDesc, IDXGISwapChain** ppSwapChain, ID3D10Device** ppDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CreateBlob"]/*' />
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CreateBlob([NativeTypeName("SIZE_T")] nuint NumBytes, [NativeTypeName("LPD3D10BLOB *")] ID3DBlob** ppBuffer);
}
