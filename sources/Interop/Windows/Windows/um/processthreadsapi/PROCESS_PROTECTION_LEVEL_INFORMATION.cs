// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PROCESS_PROTECTION_LEVEL_INFORMATION.xml' path='doc/member[@name="PROCESS_PROTECTION_LEVEL_INFORMATION"]/*' />
public partial struct PROCESS_PROTECTION_LEVEL_INFORMATION
{
    /// <include file='PROCESS_PROTECTION_LEVEL_INFORMATION.xml' path='doc/member[@name="PROCESS_PROTECTION_LEVEL_INFORMATION.ProtectionLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtectionLevel;
}
