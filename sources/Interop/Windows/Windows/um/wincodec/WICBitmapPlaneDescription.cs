// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WICBitmapPlaneDescription.xml' path='doc/member[@name="WICBitmapPlaneDescription"]/*' />
[SupportedOSPlatform("windows8.1")]
public partial struct WICBitmapPlaneDescription
{
    /// <include file='WICBitmapPlaneDescription.xml' path='doc/member[@name="WICBitmapPlaneDescription.Format"]/*' />
    [NativeTypeName("WICPixelFormatGUID")]
    public Guid Format;

    /// <include file='WICBitmapPlaneDescription.xml' path='doc/member[@name="WICBitmapPlaneDescription.Width"]/*' />
    public uint Width;

    /// <include file='WICBitmapPlaneDescription.xml' path='doc/member[@name="WICBitmapPlaneDescription.Height"]/*' />
    public uint Height;
}
