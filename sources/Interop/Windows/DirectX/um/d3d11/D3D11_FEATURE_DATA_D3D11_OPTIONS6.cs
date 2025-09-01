// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS6.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS6"]/*' />
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS6
{
    /// <include file='D3D11_FEATURE_DATA_D3D11_OPTIONS6.xml' path='doc/member[@name="D3D11_FEATURE_DATA_D3D11_OPTIONS6.ShaderAccessRestrictedResourceTier"]/*' />
    public D3D11_SHADER_ACCESS_RESTRICTED_RESOURCE_TIER ShaderAccessRestrictedResourceTier;
}
