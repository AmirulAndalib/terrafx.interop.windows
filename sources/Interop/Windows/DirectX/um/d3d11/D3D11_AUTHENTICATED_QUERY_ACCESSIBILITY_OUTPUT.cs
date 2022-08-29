// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT
{
    /// <include file='D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.Output"]/*' />
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;

    /// <include file='D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.BusType"]/*' />
    public D3D11_BUS_TYPE BusType;

    /// <include file='D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.AccessibleInContiguousBlocks"]/*' />
    public BOOL AccessibleInContiguousBlocks;

    /// <include file='D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT.AccessibleInNonContiguousBlocks"]/*' />
    public BOOL AccessibleInNonContiguousBlocks;
}
