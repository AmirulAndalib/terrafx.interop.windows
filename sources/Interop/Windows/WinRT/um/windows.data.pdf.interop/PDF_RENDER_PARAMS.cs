// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.WinRT;

/// <include file='PDF_RENDER_PARAMS.xml' path='doc/member[@name="PDF_RENDER_PARAMS"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct PDF_RENDER_PARAMS
{
    /// <include file='PDF_RENDER_PARAMS.xml' path='doc/member[@name="PDF_RENDER_PARAMS.SourceRect"]/*' />
    public D2D_RECT_F SourceRect;

    /// <include file='PDF_RENDER_PARAMS.xml' path='doc/member[@name="PDF_RENDER_PARAMS.DestinationWidth"]/*' />
    [NativeTypeName("UINT32")]
    public uint DestinationWidth;

    /// <include file='PDF_RENDER_PARAMS.xml' path='doc/member[@name="PDF_RENDER_PARAMS.DestinationHeight"]/*' />
    [NativeTypeName("UINT32")]
    public uint DestinationHeight;

    /// <include file='PDF_RENDER_PARAMS.xml' path='doc/member[@name="PDF_RENDER_PARAMS.BackgroundColor"]/*' />
    [NativeTypeName("D2D_COLOR_F")]
    public DXGI_RGBA BackgroundColor;

    /// <include file='PDF_RENDER_PARAMS.xml' path='doc/member[@name="PDF_RENDER_PARAMS.IgnoreHighContrast"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte IgnoreHighContrast;
}
