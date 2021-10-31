// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRL_CONTEXT
    {
        [NativeTypeName("DWORD")]
        public uint dwCertEncodingType;

        public byte* pbCrlEncoded;

        [NativeTypeName("DWORD")]
        public uint cbCrlEncoded;

        [NativeTypeName("PCRL_INFO")]
        public CRL_INFO* pCrlInfo;

        public HCERTSTORE hCertStore;
    }
}
