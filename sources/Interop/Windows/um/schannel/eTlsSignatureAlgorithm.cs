// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eTlsSignatureAlgorithm
    {
        TlsSignatureAlgorithm_Anonymous = 0,
        TlsSignatureAlgorithm_Rsa = 1,
        TlsSignatureAlgorithm_Dsa = 2,
        TlsSignatureAlgorithm_Ecdsa = 3,
    }
}
