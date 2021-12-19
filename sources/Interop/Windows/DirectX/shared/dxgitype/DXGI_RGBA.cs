// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA"]/*' />
public partial struct DXGI_RGBA
{
    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.r"]/*' />
    public float r;

    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.g"]/*' />
    public float g;

    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.b"]/*' />
    public float b;

    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.a"]/*' />
    public float a;
}
