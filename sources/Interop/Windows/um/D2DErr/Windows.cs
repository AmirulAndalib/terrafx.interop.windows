// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/D2DErr.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define FACILITY_D2D 0x899")]
        public const int FACILITY_D2D = 0x899;

        [NativeTypeName("#define D2DERR_UNSUPPORTED_PIXEL_FORMAT WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT")]
        public const int D2DERR_UNSUPPORTED_PIXEL_FORMAT = unchecked((int)(0x88982F80));

        [NativeTypeName("#define D2DERR_INSUFFICIENT_BUFFER HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)")]
        public static readonly int D2DERR_INSUFFICIENT_BUFFER = HRESULT_FROM_WIN32(122);

        [NativeTypeName("#define D2DERR_FILE_NOT_FOUND HRESULT_FROM_WIN32(ERROR_FILE_NOT_FOUND)")]
        public static readonly int D2DERR_FILE_NOT_FOUND = HRESULT_FROM_WIN32(2);
    }
}
