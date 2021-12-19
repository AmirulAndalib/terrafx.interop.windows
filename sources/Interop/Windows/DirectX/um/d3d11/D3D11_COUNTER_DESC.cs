// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_COUNTER_DESC.xml' path='doc/member[@name="D3D11_COUNTER_DESC"]/*' />
public partial struct D3D11_COUNTER_DESC
{
    /// <include file='D3D11_COUNTER_DESC.xml' path='doc/member[@name="D3D11_COUNTER_DESC.Counter"]/*' />
    public D3D11_COUNTER Counter;

    /// <include file='D3D11_COUNTER_DESC.xml' path='doc/member[@name="D3D11_COUNTER_DESC.MiscFlags"]/*' />
    public uint MiscFlags;
}
