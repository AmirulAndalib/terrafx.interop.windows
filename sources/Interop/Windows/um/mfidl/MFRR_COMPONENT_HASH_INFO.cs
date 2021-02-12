// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MFRR_COMPONENT_HASH_INFO
    {
        [NativeTypeName("DWORD")]
        public uint ulReason;

        [NativeTypeName("WCHAR [43]")]
        public fixed ushort rgHeaderHash[43];

        [NativeTypeName("WCHAR [43]")]
        public fixed ushort rgPublicKeyHash[43];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort wszName[260];
    }
}
