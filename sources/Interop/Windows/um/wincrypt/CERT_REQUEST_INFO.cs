// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_REQUEST_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPTOAPI_BLOB Subject;

        public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

        [NativeTypeName("DWORD")]
        public uint cAttribute;

        [NativeTypeName("PCRYPT_ATTRIBUTE")]
        public CRYPT_ATTRIBUTE* rgAttribute;
    }
}
