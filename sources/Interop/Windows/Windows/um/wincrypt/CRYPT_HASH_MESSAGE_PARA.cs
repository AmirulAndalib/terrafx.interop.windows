// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_HASH_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_HASH_MESSAGE_PARA"]/*' />
public unsafe partial struct CRYPT_HASH_MESSAGE_PARA
{
    /// <include file='CRYPT_HASH_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_HASH_MESSAGE_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CRYPT_HASH_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_HASH_MESSAGE_PARA.dwMsgEncodingType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMsgEncodingType;

    /// <include file='CRYPT_HASH_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_HASH_MESSAGE_PARA.hCryptProv"]/*' />
    public HCRYPTPROV_LEGACY hCryptProv;

    /// <include file='CRYPT_HASH_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_HASH_MESSAGE_PARA.HashAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

    /// <include file='CRYPT_HASH_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_HASH_MESSAGE_PARA.pvHashAuxInfo"]/*' />
    public void* pvHashAuxInfo;
}
