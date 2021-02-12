// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define AMDDS_NONE 0x00")]
        public const int AMDDS_NONE = 0x00;

        [NativeTypeName("#define AMDDS_DCIPS 0x01")]
        public const int AMDDS_DCIPS = 0x01;

        [NativeTypeName("#define AMDDS_PS 0x02")]
        public const int AMDDS_PS = 0x02;

        [NativeTypeName("#define AMDDS_RGBOVR 0x04")]
        public const int AMDDS_RGBOVR = 0x04;

        [NativeTypeName("#define AMDDS_YUVOVR 0x08")]
        public const int AMDDS_YUVOVR = 0x08;

        [NativeTypeName("#define AMDDS_RGBOFF 0x10")]
        public const int AMDDS_RGBOFF = 0x10;

        [NativeTypeName("#define AMDDS_YUVOFF 0x20")]
        public const int AMDDS_YUVOFF = 0x20;

        [NativeTypeName("#define AMDDS_RGBFLP 0x40")]
        public const int AMDDS_RGBFLP = 0x40;

        [NativeTypeName("#define AMDDS_YUVFLP 0x80")]
        public const int AMDDS_YUVFLP = 0x80;

        [NativeTypeName("#define AMDDS_ALL 0xFF")]
        public const int AMDDS_ALL = 0xFF;

        [NativeTypeName("#define AMDDS_DEFAULT AMDDS_ALL")]
        public const int AMDDS_DEFAULT = 0xFF;

        [NativeTypeName("#define AMDDS_YUV (AMDDS_YUVOFF | AMDDS_YUVOVR | AMDDS_YUVFLP)")]
        public const int AMDDS_YUV = (0x20 | 0x08 | 0x80);

        [NativeTypeName("#define AMDDS_RGB (AMDDS_RGBOFF | AMDDS_RGBOVR | AMDDS_RGBFLP)")]
        public const int AMDDS_RGB = (0x10 | 0x04 | 0x40);

        [NativeTypeName("#define AMDDS_PRIMARY (AMDDS_DCIPS | AMDDS_PS)")]
        public const int AMDDS_PRIMARY = (0x01 | 0x02);

        [NativeTypeName("#define iPALETTE_COLORS 256")]
        public const int iPALETTE_COLORS = 256;

        [NativeTypeName("#define iEGA_COLORS 16")]
        public const int iEGA_COLORS = 16;

        [NativeTypeName("#define iMASK_COLORS 3")]
        public const int iMASK_COLORS = 3;

        [NativeTypeName("#define iTRUECOLOR 16")]
        public const int iTRUECOLOR = 16;

        [NativeTypeName("#define iRED 0")]
        public const int iRED = 0;

        [NativeTypeName("#define iGREEN 1")]
        public const int iGREEN = 1;

        [NativeTypeName("#define iBLUE 2")]
        public const int iBLUE = 2;

        [NativeTypeName("#define iPALETTE 8")]
        public const int iPALETTE = 8;

        [NativeTypeName("#define iMAXBITS 8")]
        public const int iMAXBITS = 8;

        [NativeTypeName("#define SIZE_EGA_PALETTE (iEGA_COLORS * sizeof(RGBQUAD))")]
        public const uint SIZE_EGA_PALETTE = unchecked(16 * 4);

        [NativeTypeName("#define SIZE_PALETTE (iPALETTE_COLORS * sizeof(RGBQUAD))")]
        public const uint SIZE_PALETTE = unchecked(256 * 4);

        [NativeTypeName("#define SIZE_MASKS (iMASK_COLORS * sizeof(DWORD))")]
        public const uint SIZE_MASKS = unchecked(3 * 4);

        [NativeTypeName("#define MAX_SIZE_MPEG1_SEQUENCE_INFO 140")]
        public const int MAX_SIZE_MPEG1_SEQUENCE_INFO = 140;
    }
}
