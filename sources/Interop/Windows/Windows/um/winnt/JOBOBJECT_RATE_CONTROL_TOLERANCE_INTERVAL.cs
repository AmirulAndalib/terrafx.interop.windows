// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL.xml' path='doc/member[@name="JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL"]/*' />
public enum JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL
{
    /// <include file='JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL.xml' path='doc/member[@name="JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL.ToleranceIntervalShort"]/*' />
    ToleranceIntervalShort = 1,

    /// <include file='JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL.xml' path='doc/member[@name="JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL.ToleranceIntervalMedium"]/*' />
    ToleranceIntervalMedium,

    /// <include file='JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL.xml' path='doc/member[@name="JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL.ToleranceIntervalLong"]/*' />
    ToleranceIntervalLong,
}
