// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CMSG_MAIL_LIST_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_INFO"]/*' />
public unsafe partial struct CMSG_MAIL_LIST_RECIPIENT_INFO
{
    /// <include file='CMSG_MAIL_LIST_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_INFO.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='CMSG_MAIL_LIST_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_INFO.KeyId"]/*' />
    public CRYPT_DATA_BLOB KeyId;

    /// <include file='CMSG_MAIL_LIST_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_INFO.KeyEncryptionAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER KeyEncryptionAlgorithm;

    /// <include file='CMSG_MAIL_LIST_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_INFO.EncryptedKey"]/*' />
    public CRYPT_DATA_BLOB EncryptedKey;

    /// <include file='CMSG_MAIL_LIST_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_INFO.Date"]/*' />
    public FILETIME Date;

    /// <include file='CMSG_MAIL_LIST_RECIPIENT_INFO.xml' path='doc/member[@name="CMSG_MAIL_LIST_RECIPIENT_INFO.pOtherAttr"]/*' />
    [NativeTypeName("PCRYPT_ATTRIBUTE_TYPE_VALUE")]
    public CRYPT_ATTRIBUTE_TYPE_VALUE* pOtherAttr;
}
