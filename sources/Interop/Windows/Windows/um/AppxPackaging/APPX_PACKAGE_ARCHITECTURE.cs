// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='APPX_PACKAGE_ARCHITECTURE.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE"]/*' />
[SupportedOSPlatform("windows8.0")]
public enum APPX_PACKAGE_ARCHITECTURE
{
    /// <include file='APPX_PACKAGE_ARCHITECTURE.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE.APPX_PACKAGE_ARCHITECTURE_X86"]/*' />
    APPX_PACKAGE_ARCHITECTURE_X86 = 0,

    /// <include file='APPX_PACKAGE_ARCHITECTURE.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE.APPX_PACKAGE_ARCHITECTURE_ARM"]/*' />
    APPX_PACKAGE_ARCHITECTURE_ARM = 5,

    /// <include file='APPX_PACKAGE_ARCHITECTURE.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE.APPX_PACKAGE_ARCHITECTURE_X64"]/*' />
    APPX_PACKAGE_ARCHITECTURE_X64 = 9,

    /// <include file='APPX_PACKAGE_ARCHITECTURE.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE.APPX_PACKAGE_ARCHITECTURE_NEUTRAL"]/*' />
    APPX_PACKAGE_ARCHITECTURE_NEUTRAL = 11,

    /// <include file='APPX_PACKAGE_ARCHITECTURE.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE.APPX_PACKAGE_ARCHITECTURE_ARM64"]/*' />
    APPX_PACKAGE_ARCHITECTURE_ARM64 = 12,
}
