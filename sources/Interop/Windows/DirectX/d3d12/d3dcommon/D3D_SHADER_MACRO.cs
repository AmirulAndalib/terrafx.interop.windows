// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_SHADER_MACRO.xml' path='doc/member[@name="D3D_SHADER_MACRO"]/*' />
public unsafe partial struct D3D_SHADER_MACRO
{
    /// <include file='D3D_SHADER_MACRO.xml' path='doc/member[@name="D3D_SHADER_MACRO.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D_SHADER_MACRO.xml' path='doc/member[@name="D3D_SHADER_MACRO.Definition"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Definition;
}
