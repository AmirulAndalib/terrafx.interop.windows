// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CTL_FIND_USAGE_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public CTL_USAGE SubjectUsage;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB ListIdentifier;

        [NativeTypeName("PCERT_INFO")]
        public CERT_INFO* pSigner;
    }
}
