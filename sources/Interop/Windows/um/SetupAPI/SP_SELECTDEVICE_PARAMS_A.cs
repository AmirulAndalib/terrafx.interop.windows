// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SP_SELECTDEVICE_PARAMS_A
    {
        public SP_CLASSINSTALL_HEADER ClassInstallHeader;

        [NativeTypeName("CHAR [60]")]
        public fixed sbyte Title[60];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte Instructions[256];

        [NativeTypeName("CHAR [30]")]
        public fixed sbyte ListLabel[30];

        [NativeTypeName("CHAR [256]")]
        public fixed sbyte SubTitle[256];

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved[2];
    }
}
