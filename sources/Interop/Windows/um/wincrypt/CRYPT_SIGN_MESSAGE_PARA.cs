// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_SIGN_MESSAGE_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwMsgEncodingType;

        [NativeTypeName("PCCERT_CONTEXT")]
        public CERT_CONTEXT* pSigningCert;

        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        [NativeTypeName("void *")]
        public void* pvHashAuxInfo;

        [NativeTypeName("DWORD")]
        public uint cMsgCert;

        [NativeTypeName("PCCERT_CONTEXT *")]
        public CERT_CONTEXT** rgpMsgCert;

        [NativeTypeName("DWORD")]
        public uint cMsgCrl;

        [NativeTypeName("PCCRL_CONTEXT *")]
        public CRL_CONTEXT** rgpMsgCrl;

        [NativeTypeName("DWORD")]
        public uint cAuthAttr;

        [NativeTypeName("PCRYPT_ATTRIBUTE")]
        public CRYPT_ATTRIBUTE* rgAuthAttr;

        [NativeTypeName("DWORD")]
        public uint cUnauthAttr;

        [NativeTypeName("PCRYPT_ATTRIBUTE")]
        public CRYPT_ATTRIBUTE* rgUnauthAttr;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwInnerContentType;
    }
}
