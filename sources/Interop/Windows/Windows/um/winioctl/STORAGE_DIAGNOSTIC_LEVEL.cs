// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_DIAGNOSTIC_LEVEL.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_LEVEL"]/*' />
public enum STORAGE_DIAGNOSTIC_LEVEL
{
    /// <include file='STORAGE_DIAGNOSTIC_LEVEL.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_LEVEL.StorageDiagnosticLevelDefault"]/*' />
    StorageDiagnosticLevelDefault = 0,

    /// <include file='STORAGE_DIAGNOSTIC_LEVEL.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_LEVEL.StorageDiagnosticLevelMax"]/*' />
    StorageDiagnosticLevelMax,
}
