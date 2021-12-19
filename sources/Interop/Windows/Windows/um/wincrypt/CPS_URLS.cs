// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CPS_URLS.xml' path='doc/member[@name="CPS_URLS"]/*' />
public unsafe partial struct CPS_URLS
{
    /// <include file='CPS_URLS.xml' path='doc/member[@name="CPS_URLS.pszURL"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszURL;

    /// <include file='CPS_URLS.xml' path='doc/member[@name="CPS_URLS.pAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER* pAlgorithm;

    /// <include file='CPS_URLS.xml' path='doc/member[@name="CPS_URLS.pDigest"]/*' />
    public CRYPT_DATA_BLOB* pDigest;
}
