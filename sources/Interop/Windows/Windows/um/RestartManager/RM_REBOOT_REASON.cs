// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='RM_REBOOT_REASON.xml' path='doc/member[@name="RM_REBOOT_REASON"]/*' />
[Flags]
public enum RM_REBOOT_REASON
{
    /// <include file='RM_REBOOT_REASON.xml' path='doc/member[@name="RM_REBOOT_REASON.RmRebootReasonNone"]/*' />
    RmRebootReasonNone = 0x0,

    /// <include file='RM_REBOOT_REASON.xml' path='doc/member[@name="RM_REBOOT_REASON.RmRebootReasonPermissionDenied"]/*' />
    RmRebootReasonPermissionDenied = 0x1,

    /// <include file='RM_REBOOT_REASON.xml' path='doc/member[@name="RM_REBOOT_REASON.RmRebootReasonSessionMismatch"]/*' />
    RmRebootReasonSessionMismatch = 0x2,

    /// <include file='RM_REBOOT_REASON.xml' path='doc/member[@name="RM_REBOOT_REASON.RmRebootReasonCriticalProcess"]/*' />
    RmRebootReasonCriticalProcess = 0x4,

    /// <include file='RM_REBOOT_REASON.xml' path='doc/member[@name="RM_REBOOT_REASON.RmRebootReasonCriticalService"]/*' />
    RmRebootReasonCriticalService = 0x8,

    /// <include file='RM_REBOOT_REASON.xml' path='doc/member[@name="RM_REBOOT_REASON.RmRebootReasonDetectedSelf"]/*' />
    RmRebootReasonDetectedSelf = 0x10,
}
