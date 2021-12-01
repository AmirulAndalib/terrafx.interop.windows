// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CERT_LOGOTYPE_DETAILS.xml' path='doc/member[@name="CERT_LOGOTYPE_DETAILS"]/*' />
public unsafe partial struct CERT_LOGOTYPE_DETAILS
{
    /// <include file='CERT_LOGOTYPE_DETAILS.xml' path='doc/member[@name="CERT_LOGOTYPE_DETAILS.pwszMimeType"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszMimeType;

    /// <include file='CERT_LOGOTYPE_DETAILS.xml' path='doc/member[@name="CERT_LOGOTYPE_DETAILS.cHashedUrl"]/*' />
    [NativeTypeName("DWORD")]
    public uint cHashedUrl;

    /// <include file='CERT_LOGOTYPE_DETAILS.xml' path='doc/member[@name="CERT_LOGOTYPE_DETAILS.rgHashedUrl"]/*' />
    [NativeTypeName("PCERT_HASHED_URL")]
    public CERT_HASHED_URL* rgHashedUrl;
}
