// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SIP_CAP_SET_V2
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("BOOL")]
        public int isMultiSign;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }
}
