// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SHADER_DEBUG_VAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VAR_INFO"]/*' />
public partial struct D3D10_SHADER_DEBUG_VAR_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_VAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VAR_INFO.TokenId"]/*' />
    public uint TokenId;

    /// <include file='D3D10_SHADER_DEBUG_VAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VAR_INFO.Type"]/*' />
    [NativeTypeName("D3D10_SHADER_VARIABLE_TYPE")]
    public D3D_SHADER_VARIABLE_TYPE Type;

    /// <include file='D3D10_SHADER_DEBUG_VAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VAR_INFO.Register"]/*' />
    public uint Register;

    /// <include file='D3D10_SHADER_DEBUG_VAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VAR_INFO.Component"]/*' />
    public uint Component;

    /// <include file='D3D10_SHADER_DEBUG_VAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VAR_INFO.ScopeVar"]/*' />
    public uint ScopeVar;

    /// <include file='D3D10_SHADER_DEBUG_VAR_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_VAR_INFO.ScopeVarOffset"]/*' />
    public uint ScopeVarOffset;
}
