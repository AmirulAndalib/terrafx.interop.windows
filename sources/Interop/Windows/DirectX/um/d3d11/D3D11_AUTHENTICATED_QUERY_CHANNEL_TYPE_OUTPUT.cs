// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT
{
    /// <include file='D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT.Output"]/*' />
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// <include file='D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_CHANNEL_TYPE_OUTPUT.ChannelType"]/*' />
    public D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType;
}
