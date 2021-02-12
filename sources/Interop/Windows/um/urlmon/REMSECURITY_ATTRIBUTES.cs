// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct REMSECURITY_ATTRIBUTES
    {
        [NativeTypeName("DWORD")]
        public uint nLength;

        [NativeTypeName("DWORD")]
        public uint lpSecurityDescriptor;

        [NativeTypeName("BOOL")]
        public int bInheritHandle;
    }
}
