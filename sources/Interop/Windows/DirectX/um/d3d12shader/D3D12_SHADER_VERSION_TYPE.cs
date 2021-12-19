// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE"]/*' />
public enum D3D12_SHADER_VERSION_TYPE
{
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_PIXEL_SHADER"]/*' />
    D3D12_SHVER_PIXEL_SHADER = 0,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_VERTEX_SHADER"]/*' />
    D3D12_SHVER_VERTEX_SHADER = 1,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_GEOMETRY_SHADER"]/*' />
    D3D12_SHVER_GEOMETRY_SHADER = 2,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_HULL_SHADER"]/*' />
    D3D12_SHVER_HULL_SHADER = 3,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_DOMAIN_SHADER"]/*' />
    D3D12_SHVER_DOMAIN_SHADER = 4,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_COMPUTE_SHADER"]/*' />
    D3D12_SHVER_COMPUTE_SHADER = 5,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_RESERVED0"]/*' />
    D3D12_SHVER_RESERVED0 = 0xFFF0,
}
