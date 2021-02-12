// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WICImageParameters
    {
        public D2D1_PIXEL_FORMAT PixelFormat;

        [NativeTypeName("FLOAT")]
        public float DpiX;

        [NativeTypeName("FLOAT")]
        public float DpiY;

        [NativeTypeName("FLOAT")]
        public float Top;

        [NativeTypeName("FLOAT")]
        public float Left;

        [NativeTypeName("UINT32")]
        public uint PixelWidth;

        [NativeTypeName("UINT32")]
        public uint PixelHeight;
    }
}
