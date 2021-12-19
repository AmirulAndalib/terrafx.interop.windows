// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TRUSTED_DOMAIN_FULL_INFORMATION2.xml' path='doc/member[@name="TRUSTED_DOMAIN_FULL_INFORMATION2"]/*' />
public partial struct TRUSTED_DOMAIN_FULL_INFORMATION2
{
    /// <include file='TRUSTED_DOMAIN_FULL_INFORMATION2.xml' path='doc/member[@name="TRUSTED_DOMAIN_FULL_INFORMATION2.Information"]/*' />
    public TRUSTED_DOMAIN_INFORMATION_EX2 Information;

    /// <include file='TRUSTED_DOMAIN_FULL_INFORMATION2.xml' path='doc/member[@name="TRUSTED_DOMAIN_FULL_INFORMATION2.PosixOffset"]/*' />
    public TRUSTED_POSIX_OFFSET_INFO PosixOffset;

    /// <include file='TRUSTED_DOMAIN_FULL_INFORMATION2.xml' path='doc/member[@name="TRUSTED_DOMAIN_FULL_INFORMATION2.AuthInformation"]/*' />
    public TRUSTED_DOMAIN_AUTH_INFORMATION AuthInformation;
}
