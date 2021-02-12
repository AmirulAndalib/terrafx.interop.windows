// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_CTRL_VERIFY_SIGNATURE_EX_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCRYPTPROV_LEGACY")]
        public nuint hCryptProv;

        [NativeTypeName("DWORD")]
        public uint dwSignerIndex;

        [NativeTypeName("DWORD")]
        public uint dwSignerType;

        [NativeTypeName("void *")]
        public void* pvSigner;
    }
}
