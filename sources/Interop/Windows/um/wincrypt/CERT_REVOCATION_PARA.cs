// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_REVOCATION_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PCCERT_CONTEXT")]
        public CERT_CONTEXT* pIssuerCert;

        [NativeTypeName("DWORD")]
        public uint cCertStore;

        [NativeTypeName("HCERTSTORE *")]
        public void** rgCertStore;

        [NativeTypeName("HCERTSTORE")]
        public void* hCrlStore;

        [NativeTypeName("LPFILETIME")]
        public FILETIME* pftTimeToUse;
    }
}
