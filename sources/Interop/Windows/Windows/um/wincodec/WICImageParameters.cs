// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

/// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct WICImageParameters
{
    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.PixelFormat"]/*' />
    public D2D1_PIXEL_FORMAT PixelFormat;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.DpiX"]/*' />
    public float DpiX;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.DpiY"]/*' />
    public float DpiY;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.Top"]/*' />
    public float Top;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.Left"]/*' />
    public float Left;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.PixelWidth"]/*' />
    [NativeTypeName("UINT32")]
    public uint PixelWidth;

    /// <include file='WICImageParameters.xml' path='doc/member[@name="WICImageParameters.PixelHeight"]/*' />
    [NativeTypeName("UINT32")]
    public uint PixelHeight;
}
