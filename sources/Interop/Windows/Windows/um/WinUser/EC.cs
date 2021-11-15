// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class EC
    {
        [NativeTypeName("#define EC_LEFTMARGIN 0x0001")]
        public const int EC_LEFTMARGIN = 0x0001;

        [NativeTypeName("#define EC_RIGHTMARGIN 0x0002")]
        public const int EC_RIGHTMARGIN = 0x0002;

        [NativeTypeName("#define EC_USEFONTINFO 0xffff")]
        public const int EC_USEFONTINFO = 0xffff;
    }
}
