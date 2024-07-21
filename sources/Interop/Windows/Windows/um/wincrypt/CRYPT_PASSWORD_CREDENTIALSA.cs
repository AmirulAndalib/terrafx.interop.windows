// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_PASSWORD_CREDENTIALSA.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSA"]/*' />
public unsafe partial struct CRYPT_PASSWORD_CREDENTIALSA
{
    /// <include file='CRYPT_PASSWORD_CREDENTIALSA.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CRYPT_PASSWORD_CREDENTIALSA.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSA.pszUsername"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszUsername;

    /// <include file='CRYPT_PASSWORD_CREDENTIALSA.xml' path='doc/member[@name="CRYPT_PASSWORD_CREDENTIALSA.pszPassword"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszPassword;
}
