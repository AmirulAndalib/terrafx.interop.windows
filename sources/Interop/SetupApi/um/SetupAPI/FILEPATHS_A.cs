// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct FILEPATHS_A
    {
        [NativeTypeName("PCSTR")]
        public sbyte* Target;

        [NativeTypeName("PCSTR")]
        public sbyte* Source;

        [NativeTypeName("UINT")]
        public uint Win32Error;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
