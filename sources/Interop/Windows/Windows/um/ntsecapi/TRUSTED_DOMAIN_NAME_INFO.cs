// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TRUSTED_DOMAIN_NAME_INFO.xml' path='doc/member[@name="TRUSTED_DOMAIN_NAME_INFO"]/*' />
public partial struct TRUSTED_DOMAIN_NAME_INFO
{
    /// <include file='TRUSTED_DOMAIN_NAME_INFO.xml' path='doc/member[@name="TRUSTED_DOMAIN_NAME_INFO.Name"]/*' />
    public LSA_UNICODE_STRING Name;
}
