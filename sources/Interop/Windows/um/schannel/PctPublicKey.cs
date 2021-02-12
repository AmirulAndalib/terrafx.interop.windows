// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PctPublicKey
    {
        [NativeTypeName("DWORD")]
        public uint Type;

        [NativeTypeName("DWORD")]
        public uint cbKey;

        [NativeTypeName("UCHAR [1]")]
        public fixed byte pKey[1];
    }
}
