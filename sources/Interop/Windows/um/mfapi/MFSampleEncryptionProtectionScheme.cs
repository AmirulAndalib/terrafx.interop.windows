// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFSampleEncryptionProtectionScheme
    {
        MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_NONE = 0,
        MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CTR = 1,
        MF_SAMPLE_ENCRYPTION_PROTECTION_SCHEME_AES_CBC = 2,
    }
}
