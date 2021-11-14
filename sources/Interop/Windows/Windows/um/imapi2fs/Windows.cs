// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define IMAPI2FS_BOOT_ENTRY_COUNT_MAX 32")]
        public const int IMAPI2FS_BOOT_ENTRY_COUNT_MAX = 32;

        [NativeTypeName("#define IMAPI2FS_MajorVersion 1")]
        public const int IMAPI2FS_MajorVersion = 1;

        [NativeTypeName("#define IMAPI2FS_MinorVersion 0")]
        public const int IMAPI2FS_MinorVersion = 0;

        [NativeTypeName("#define IMAPI2FS_FullVersion_STR \"1.0\"")]
        public static ReadOnlySpan<byte> IMAPI2FS_FullVersion_STR => new byte[] { 0x31, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define IMAPI2FS_FullVersion_WSTR L\"1.0\"")]
        public const string IMAPI2FS_FullVersion_WSTR = "1.0";
    }
}
