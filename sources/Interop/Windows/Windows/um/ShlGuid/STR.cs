// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public static partial class STR
    {
        [NativeTypeName("#define STR_MYDOCS_CLSID \"{450D8FBA-AD25-11D0-98A8-0800361B1103}\"")]
        public static ReadOnlySpan<byte> STR_MYDOCS_CLSID => new byte[] { 0x7B, 0x34, 0x35, 0x30, 0x44, 0x38, 0x46, 0x42, 0x41, 0x2D, 0x41, 0x44, 0x32, 0x35, 0x2D, 0x31, 0x31, 0x44, 0x30, 0x2D, 0x39, 0x38, 0x41, 0x38, 0x2D, 0x30, 0x38, 0x30, 0x30, 0x33, 0x36, 0x31, 0x42, 0x31, 0x31, 0x30, 0x33, 0x7D, 0x00 };
    }
}