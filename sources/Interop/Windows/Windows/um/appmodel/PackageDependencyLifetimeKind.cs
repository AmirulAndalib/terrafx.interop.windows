// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PackageDependencyLifetimeKind.xml' path='doc/member[@name="PackageDependencyLifetimeKind"]/*' />
[SupportedOSPlatform("windows10.0.22621.0")]
public enum PackageDependencyLifetimeKind
{
    /// <include file='PackageDependencyLifetimeKind.xml' path='doc/member[@name="PackageDependencyLifetimeKind.PackageDependencyLifetimeKind_Process"]/*' />
    PackageDependencyLifetimeKind_Process = 0,

    /// <include file='PackageDependencyLifetimeKind.xml' path='doc/member[@name="PackageDependencyLifetimeKind.PackageDependencyLifetimeKind_FilePath"]/*' />
    PackageDependencyLifetimeKind_FilePath = 1,

    /// <include file='PackageDependencyLifetimeKind.xml' path='doc/member[@name="PackageDependencyLifetimeKind.PackageDependencyLifetimeKind_RegistryKey"]/*' />
    PackageDependencyLifetimeKind_RegistryKey = 2,
}
