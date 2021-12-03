// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CUSTOM_RATE"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct D3D11_VIDEO_PROCESSOR_CUSTOM_RATE
{
    /// <include file='D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.CustomRate"]/*' />
    public DXGI_RATIONAL CustomRate;

    /// <include file='D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.OutputFrames"]/*' />
    public uint OutputFrames;

    /// <include file='D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.InputInterlaced"]/*' />
    public BOOL InputInterlaced;

    /// <include file='D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CUSTOM_RATE.InputFramesOrFields"]/*' />
    public uint InputFramesOrFields;
}
