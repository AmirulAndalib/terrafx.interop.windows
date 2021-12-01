// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_HASH_INFO.xml' path='doc/member[@name="CRYPT_HASH_INFO"]/*' />
public partial struct CRYPT_HASH_INFO
{
    /// <include file='CRYPT_HASH_INFO.xml' path='doc/member[@name="CRYPT_HASH_INFO.HashAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

    /// <include file='CRYPT_HASH_INFO.xml' path='doc/member[@name="CRYPT_HASH_INFO.Hash"]/*' />
    [NativeTypeName("CRYPT_HASH_BLOB")]
    public CRYPT_DATA_BLOB Hash;
}
