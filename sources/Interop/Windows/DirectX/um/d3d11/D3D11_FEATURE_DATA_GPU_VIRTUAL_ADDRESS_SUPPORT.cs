// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.xml' path='doc/member[@name="D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT"]/*' />
public partial struct D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT
{
    /// <include file='D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.xml' path='doc/member[@name="D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.MaxGPUVirtualAddressBitsPerResource"]/*' />
    public uint MaxGPUVirtualAddressBitsPerResource;

    /// <include file='D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.xml' path='doc/member[@name="D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT.MaxGPUVirtualAddressBitsPerProcess"]/*' />
    public uint MaxGPUVirtualAddressBitsPerProcess;
}
