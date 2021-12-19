// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS11.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS11"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS11
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS11.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS11.AtomicInt64OnDescriptorHeapResourceSupported"]/*' />
    public BOOL AtomicInt64OnDescriptorHeapResourceSupported;
}