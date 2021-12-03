// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC"]/*' />
public unsafe partial struct D3D11_SHADER_INPUT_BIND_DESC
{
    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.Type"]/*' />
    public D3D_SHADER_INPUT_TYPE Type;

    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.BindPoint"]/*' />
    public uint BindPoint;

    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.BindCount"]/*' />
    public uint BindCount;

    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.uFlags"]/*' />
    public uint uFlags;

    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.ReturnType"]/*' />
    public D3D_RESOURCE_RETURN_TYPE ReturnType;

    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.Dimension"]/*' />
    public D3D_SRV_DIMENSION Dimension;

    /// <include file='D3D11_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D11_SHADER_INPUT_BIND_DESC.NumSamples"]/*' />
    public uint NumSamples;
}
