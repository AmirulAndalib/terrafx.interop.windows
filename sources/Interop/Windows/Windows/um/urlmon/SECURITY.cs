// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class SECURITY
    {
        [NativeTypeName("#define SECURITY_IE_STATE_GREEN 0x00000000")]
        public const int SECURITY_IE_STATE_GREEN = 0x00000000;

        [NativeTypeName("#define SECURITY_IE_STATE_RED 0x00000001")]
        public const int SECURITY_IE_STATE_RED = 0x00000001;
    }
}
