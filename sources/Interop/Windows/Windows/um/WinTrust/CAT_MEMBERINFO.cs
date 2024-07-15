// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CAT_MEMBERINFO.xml' path='doc/member[@name="CAT_MEMBERINFO"]/*' />
public unsafe partial struct CAT_MEMBERINFO
{
    /// <include file='CAT_MEMBERINFO.xml' path='doc/member[@name="CAT_MEMBERINFO.pwszSubjGuid"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pwszSubjGuid;

    /// <include file='CAT_MEMBERINFO.xml' path='doc/member[@name="CAT_MEMBERINFO.dwCertVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCertVersion;
}
