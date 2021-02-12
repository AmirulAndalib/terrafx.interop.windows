// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_SIMPLE_CHAIN
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public CERT_TRUST_STATUS TrustStatus;

        [NativeTypeName("DWORD")]
        public uint cElement;

        [NativeTypeName("PCERT_CHAIN_ELEMENT *")]
        public CERT_CHAIN_ELEMENT** rgpElement;

        [NativeTypeName("PCERT_TRUST_LIST_INFO")]
        public CERT_TRUST_LIST_INFO* pTrustListInfo;

        [NativeTypeName("BOOL")]
        public int fHasRevocationFreshnessTime;

        [NativeTypeName("DWORD")]
        public uint dwRevocationFreshnessTime;
    }
}
