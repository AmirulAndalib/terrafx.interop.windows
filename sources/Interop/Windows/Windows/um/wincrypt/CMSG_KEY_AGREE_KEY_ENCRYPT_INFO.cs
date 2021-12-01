// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CMSG_KEY_AGREE_KEY_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_KEY_ENCRYPT_INFO"]/*' />
public partial struct CMSG_KEY_AGREE_KEY_ENCRYPT_INFO
{
    /// <include file='CMSG_KEY_AGREE_KEY_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_KEY_ENCRYPT_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_KEY_AGREE_KEY_ENCRYPT_INFO.xml' path='doc/member[@name="CMSG_KEY_AGREE_KEY_ENCRYPT_INFO.EncryptedKey"]/*' />
    public CRYPT_DATA_BLOB EncryptedKey;
}
