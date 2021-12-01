// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CERT_RDN_ATTR.xml' path='doc/member[@name="CERT_RDN_ATTR"]/*' />
public unsafe partial struct CERT_RDN_ATTR
{
    /// <include file='CERT_RDN_ATTR.xml' path='doc/member[@name="CERT_RDN_ATTR.pszObjId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;

    /// <include file='CERT_RDN_ATTR.xml' path='doc/member[@name="CERT_RDN_ATTR.dwValueType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwValueType;

    /// <include file='CERT_RDN_ATTR.xml' path='doc/member[@name="CERT_RDN_ATTR.Value"]/*' />
    [NativeTypeName("CERT_RDN_VALUE_BLOB")]
    public CRYPT_DATA_BLOB Value;
}
