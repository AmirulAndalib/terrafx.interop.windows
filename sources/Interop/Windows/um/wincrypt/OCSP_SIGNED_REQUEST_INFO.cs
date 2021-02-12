// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct OCSP_SIGNED_REQUEST_INFO
    {
        [NativeTypeName("CRYPT_DER_BLOB")]
        public CRYPTOAPI_BLOB ToBeSigned;

        [NativeTypeName("POCSP_SIGNATURE_INFO")]
        public OCSP_SIGNATURE_INFO* pOptionalSignatureInfo;
    }
}
