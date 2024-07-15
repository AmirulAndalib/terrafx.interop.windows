// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D11_SUBRESOURCE_DATA"]/*' />
public unsafe partial struct D3D11_SUBRESOURCE_DATA
{
    /// <include file='D3D11_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D11_SUBRESOURCE_DATA.pSysMem"]/*' />
    [NativeTypeName("const void *")]
    public void* pSysMem;

    /// <include file='D3D11_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D11_SUBRESOURCE_DATA.SysMemPitch"]/*' />
    public uint SysMemPitch;

    /// <include file='D3D11_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D11_SUBRESOURCE_DATA.SysMemSlicePitch"]/*' />
    public uint SysMemSlicePitch;
}
