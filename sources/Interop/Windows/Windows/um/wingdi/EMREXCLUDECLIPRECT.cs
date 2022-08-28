// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='EMREXCLUDECLIPRECT.xml' path='doc/member[@name="EMREXCLUDECLIPRECT"]/*' />
public partial struct EMREXCLUDECLIPRECT
{
    /// <include file='EMREXCLUDECLIPRECT.xml' path='doc/member[@name="EMREXCLUDECLIPRECT.emr"]/*' />
    public EMR emr;

    /// <include file='EMREXCLUDECLIPRECT.xml' path='doc/member[@name="EMREXCLUDECLIPRECT.rclClip"]/*' />
    public RECTL rclClip;
}
