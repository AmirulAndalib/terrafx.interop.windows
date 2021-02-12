// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static unsafe PDF_RENDER_PARAMS PdfRenderParams([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* srcRect, [NativeTypeName("UINT32")] uint destinationWidth, [NativeTypeName("UINT32")] uint destinationHeight, [NativeTypeName("const D2D_COLOR_F &")] DXGI_RGBA* bkColor, [NativeTypeName("BOOLEAN")] byte ignoreHighContrast)
        {
            PDF_RENDER_PARAMS p = new PDF_RENDER_PARAMS
            {
                SourceRect = *srcRect,
                DestinationWidth = destinationWidth,
                DestinationHeight = destinationHeight,
                BackgroundColor = *bkColor,
                IgnoreHighContrast = ignoreHighContrast,
            };

            return p;
        }
    }
}
