// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_LIBRARY_DESC.xml' path='doc/member[@name="D3D11_LIBRARY_DESC"]/*' />
public unsafe partial struct D3D11_LIBRARY_DESC
{
    /// <include file='D3D11_LIBRARY_DESC.xml' path='doc/member[@name="D3D11_LIBRARY_DESC.Creator"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;

    /// <include file='D3D11_LIBRARY_DESC.xml' path='doc/member[@name="D3D11_LIBRARY_DESC.Flags"]/*' />
    public uint Flags;

    /// <include file='D3D11_LIBRARY_DESC.xml' path='doc/member[@name="D3D11_LIBRARY_DESC.FunctionCount"]/*' />
    public uint FunctionCount;
}
