// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DWRITE_GLYPH_RUN
    {
        [NativeTypeName("IDWriteFontFace *")]
        public IDWriteFontFace* fontFace;

        [NativeTypeName("FLOAT")]
        public float fontEmSize;

        [NativeTypeName("UINT32")]
        public uint glyphCount;

        [NativeTypeName("const UINT16 *")]
        public ushort* glyphIndices;

        [NativeTypeName("const FLOAT *")]
        public float* glyphAdvances;

        [NativeTypeName("const DWRITE_GLYPH_OFFSET *")]
        public DWRITE_GLYPH_OFFSET* glyphOffsets;

        [NativeTypeName("BOOL")]
        public int isSideways;

        [NativeTypeName("UINT32")]
        public uint bidiLevel;
    }
}
