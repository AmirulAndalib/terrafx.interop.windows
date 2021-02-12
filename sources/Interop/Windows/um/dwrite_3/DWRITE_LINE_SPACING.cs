// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_LINE_SPACING
    {
        public DWRITE_LINE_SPACING_METHOD method;

        [NativeTypeName("FLOAT")]
        public float height;

        [NativeTypeName("FLOAT")]
        public float baseline;

        [NativeTypeName("FLOAT")]
        public float leadingBefore;

        public DWRITE_FONT_LINE_GAP_USAGE fontLineGapUsage;
    }
}
