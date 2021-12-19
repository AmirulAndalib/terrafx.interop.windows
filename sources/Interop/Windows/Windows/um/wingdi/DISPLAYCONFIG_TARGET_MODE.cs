// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_TARGET_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_MODE"]/*' />
public partial struct DISPLAYCONFIG_TARGET_MODE
{
    /// <include file='DISPLAYCONFIG_TARGET_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_MODE.targetVideoSignalInfo"]/*' />
    public DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
}
