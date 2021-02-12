// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CERT_AUTHORITY_KEY_ID_INFO
    {
        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB KeyId;

        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPTOAPI_BLOB CertIssuer;

        [NativeTypeName("CRYPT_INTEGER_BLOB")]
        public CRYPTOAPI_BLOB CertSerialNumber;
    }
}
