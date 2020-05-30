// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IDCompositionAffineTransform2DEffect = new Guid(0x0B74B9E8, 0xCDD6, 0x492F, 0xBB, 0xBC, 0x5E, 0xD3, 0x21, 0x57, 0x02, 0x6D);

        public static readonly Guid IDCompositionArithmeticCompositeEffect = new Guid(0x3B67DFA8, 0xE3DD, 0x4E61, 0xB6, 0x40, 0x46, 0xC2, 0xF3, 0xD7, 0x39, 0xDC);

        public static readonly Guid IDCompositionBlendEffect = new Guid(0x33ECDC0A, 0x578A, 0x4A11, 0x9C, 0x14, 0x0C, 0xB9, 0x05, 0x17, 0xF9, 0xC5);

        public static readonly Guid IDCompositionBrightnessEffect = new Guid(0x6027496E, 0xCB3A, 0x49AB, 0x93, 0x4F, 0xD7, 0x98, 0xDA, 0x4F, 0x7D, 0xA6);

        public static readonly Guid IDCompositionClip = new Guid(0x64AC3703, 0x9D3F, 0x45EC, 0xA1, 0x09, 0x7C, 0xAC, 0x0E, 0x7A, 0x13, 0xA7);

        public static readonly Guid IDCompositionColorMatrixEffect = new Guid(0xC1170A22, 0x3CE2, 0x4966, 0x90, 0xD4, 0x55, 0x40, 0x8B, 0xFC, 0x84, 0xC4);

        public static readonly Guid IDCompositionCompositeEffect = new Guid(0x576616C0, 0xA231, 0x494D, 0xA3, 0x8D, 0x00, 0xFD, 0x5E, 0xC4, 0xDB, 0x46);

        public static readonly Guid IDCompositionDesktopDevice = new Guid(0x5F4633FE, 0x1E08, 0x4CB8, 0x8C, 0x75, 0xCE, 0x24, 0x33, 0x3F, 0x56, 0x02);

        public static readonly Guid IDCompositionDevice2 = new Guid(0x75F6468D, 0x1B8E, 0x447C, 0x9B, 0xC6, 0x75, 0xFE, 0xA8, 0x0B, 0x5B, 0x25);

        public static readonly Guid IDCompositionDevice3 = new Guid(0x0987CB06, 0xF916, 0x48BF, 0x8D, 0x35, 0xCE, 0x76, 0x41, 0x78, 0x1B, 0xD9);

        public static readonly Guid IDCompositionDevice = new Guid(0xC37EA93A, 0xE7AA, 0x450D, 0xB1, 0x6F, 0x97, 0x46, 0xCB, 0x04, 0x07, 0xF3);

        public static readonly Guid IDCompositionDeviceDebug = new Guid(0xA1A3C64A, 0x224F, 0x4A81, 0x97, 0x73, 0x4F, 0x03, 0xA8, 0x9D, 0x3C, 0x6C);

        public static readonly Guid IDCompositionEffect = new Guid(0xEC81B08F, 0xBFCB, 0x4E8D, 0xB1, 0x93, 0xA9, 0x15, 0x58, 0x79, 0x99, 0xE8);

        public static readonly Guid IDCompositionEffectGroup = new Guid(0xA7929A74, 0xE6B2, 0x4BD6, 0x8B, 0x95, 0x40, 0x40, 0x11, 0x9C, 0xA3, 0x4D);

        public static readonly Guid IDCompositionFilterEffect = new Guid(0x30C421D5, 0x8CB2, 0x4E9F, 0xB1, 0x33, 0x37, 0xBE, 0x27, 0x0D, 0x4A, 0xC2);

        public static readonly Guid IDCompositionGaussianBlurEffect = new Guid(0x45D4D0B7, 0x1BD4, 0x454E, 0x88, 0x94, 0x2B, 0xFA, 0x68, 0x44, 0x30, 0x33);

        public static readonly Guid IDCompositionHueRotationEffect = new Guid(0x6DB9F920, 0x0770, 0x4781, 0xB0, 0xC6, 0x38, 0x19, 0x12, 0xF9, 0xD1, 0x67);

        public static readonly Guid IDCompositionLinearTransferEffect = new Guid(0x4305EE5B, 0xC4A0, 0x4C88, 0x93, 0x85, 0x67, 0x12, 0x4E, 0x01, 0x76, 0x83);

        public static readonly Guid IDCompositionMatrixTransform3D = new Guid(0x4B3363F0, 0x643B, 0x41B7, 0xB6, 0xE0, 0xCC, 0xF2, 0x2D, 0x34, 0x46, 0x7C);

        public static readonly Guid IDCompositionMatrixTransform = new Guid(0x16CDFF07, 0xC503, 0x419C, 0x83, 0xF2, 0x09, 0x65, 0xC7, 0xAF, 0x1F, 0xA6);

        public static readonly Guid IDCompositionRectangleClip = new Guid(0x9842AD7D, 0xD9CF, 0x4908, 0xAE, 0xD7, 0x48, 0xB5, 0x1D, 0xA5, 0xE7, 0xC2);

        public static readonly Guid IDCompositionRotateTransform3D = new Guid(0xD8F5B23F, 0xD429, 0x4A91, 0xB5, 0x5A, 0xD2, 0xF4, 0x5F, 0xD7, 0x5B, 0x18);

        public static readonly Guid IDCompositionRotateTransform = new Guid(0x641ED83C, 0xAE96, 0x46C5, 0x90, 0xDC, 0x32, 0x77, 0x4C, 0xC5, 0xC6, 0xD5);

        public static readonly Guid IDCompositionSaturationEffect = new Guid(0xA08DEBDA, 0x3258, 0x4FA4, 0x9F, 0x16, 0x91, 0x74, 0xD3, 0xFE, 0x93, 0xB1);

        public static readonly Guid IDCompositionScaleTransform3D = new Guid(0x2A9E9EAD, 0x364B, 0x4B15, 0xA7, 0xC4, 0xA1, 0x99, 0x7F, 0x78, 0xB3, 0x89);

        public static readonly Guid IDCompositionScaleTransform = new Guid(0x71FDE914, 0x40EF, 0x45EF, 0xBD, 0x51, 0x68, 0xB0, 0x37, 0xC3, 0x39, 0xF9);

        public static readonly Guid IDCompositionShadowEffect = new Guid(0x4AD18AC0, 0xCFD2, 0x4C2F, 0xBB, 0x62, 0x96, 0xE5, 0x4F, 0xDB, 0x68, 0x79);

        public static readonly Guid IDCompositionSkewTransform = new Guid(0xE57AA735, 0xDCDB, 0x4C72, 0x9C, 0x61, 0x05, 0x91, 0xF5, 0x88, 0x89, 0xEE);

        public static readonly Guid IDCompositionSurface = new Guid(0xBB8A4953, 0x2C99, 0x4F5A, 0x96, 0xF5, 0x48, 0x19, 0x02, 0x7F, 0xA3, 0xAC);

        public static readonly Guid IDCompositionSurfaceFactory = new Guid(0xE334BC12, 0x3937, 0x4E02, 0x85, 0xEB, 0xFC, 0xF4, 0xEB, 0x30, 0xD2, 0xC8);

        public static readonly Guid IDCompositionTableTransferEffect = new Guid(0x9B7E82E2, 0x69C5, 0x4EB4, 0xA5, 0xF5, 0xA7, 0x03, 0x3F, 0x51, 0x32, 0xCD);

        public static readonly Guid IDCompositionTarget = new Guid(0xEACDD04C, 0x117E, 0x4E17, 0x88, 0xF4, 0xD1, 0xB1, 0x2B, 0x0E, 0x3D, 0x89);

        public static readonly Guid IDCompositionTransform3D = new Guid(0x71185722, 0x246B, 0x41F2, 0xAA, 0xD1, 0x04, 0x43, 0xF7, 0xF4, 0xBF, 0xC2);

        public static readonly Guid IDCompositionTransform = new Guid(0xFD55FAA7, 0x37E0, 0x4C20, 0x95, 0xD2, 0x9B, 0xE4, 0x5B, 0xC3, 0x3F, 0x55);

        public static readonly Guid IDCompositionTranslateTransform3D = new Guid(0x91636D4B, 0x9BA1, 0x4532, 0xAA, 0xF7, 0xE3, 0x34, 0x49, 0x94, 0xD7, 0x88);

        public static readonly Guid IDCompositionTranslateTransform = new Guid(0x06791122, 0xC6F0, 0x417D, 0x83, 0x23, 0x26, 0x9E, 0x98, 0x7F, 0x59, 0x54);

        public static readonly Guid IDCompositionTurbulenceEffect = new Guid(0xA6A55BDA, 0xC09C, 0x49F3, 0x91, 0x93, 0xA4, 0x19, 0x22, 0xC8, 0x97, 0x15);

        public static readonly Guid IDCompositionVirtualSurface = new Guid(0xAE471C51, 0x5F53, 0x4A24, 0x8D, 0x3E, 0xD0, 0xC3, 0x9C, 0x30, 0xB3, 0xF0);

        public static readonly Guid IDCompositionVisual2 = new Guid(0xE8DE1639, 0x4331, 0x4B26, 0xBC, 0x5F, 0x6A, 0x32, 0x1D, 0x34, 0x7A, 0x85);

        public static readonly Guid IDCompositionVisual3 = new Guid(0x2775F462, 0xB6C1, 0x4015, 0xB0, 0xBE, 0xB3, 0xE7, 0xD6, 0xA4, 0x97, 0x6D);

        public static readonly Guid IDCompositionVisual = new Guid(0x4D93059D, 0x097B, 0x4651, 0x9A, 0x60, 0xF0, 0xF2, 0x51, 0x16, 0xE2, 0xF3);

        public static readonly Guid IDCompositionVisualDebug = new Guid(0xFED2B808, 0x5EB4, 0x43A0, 0xAE, 0xA3, 0x35, 0xF6, 0x52, 0x80, 0xF9, 0x1B);

    }
}