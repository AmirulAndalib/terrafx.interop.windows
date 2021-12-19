// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='JOB_OBJECT_IO_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_IO_RATE_CONTROL_FLAGS"]/*' />
[Flags]
public enum JOB_OBJECT_IO_RATE_CONTROL_FLAGS
{
    /// <include file='JOB_OBJECT_IO_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_IO_RATE_CONTROL_FLAGS.JOB_OBJECT_IO_RATE_CONTROL_ENABLE"]/*' />
    JOB_OBJECT_IO_RATE_CONTROL_ENABLE = 0x1,

    /// <include file='JOB_OBJECT_IO_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_IO_RATE_CONTROL_FLAGS.JOB_OBJECT_IO_RATE_CONTROL_STANDALONE_VOLUME"]/*' />
    JOB_OBJECT_IO_RATE_CONTROL_STANDALONE_VOLUME = 0x2,

    /// <include file='JOB_OBJECT_IO_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_IO_RATE_CONTROL_FLAGS.JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ALL"]/*' />
    JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ALL = 0x4,

    /// <include file='JOB_OBJECT_IO_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_IO_RATE_CONTROL_FLAGS.JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ON_SOFT_CAP"]/*' />
    JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ON_SOFT_CAP = 0x8,

    /// <include file='JOB_OBJECT_IO_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="JOB_OBJECT_IO_RATE_CONTROL_FLAGS.JOB_OBJECT_IO_RATE_CONTROL_VALID_FLAGS"]/*' />
    JOB_OBJECT_IO_RATE_CONTROL_VALID_FLAGS = JOB_OBJECT_IO_RATE_CONTROL_ENABLE | JOB_OBJECT_IO_RATE_CONTROL_STANDALONE_VOLUME | JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ALL | JOB_OBJECT_IO_RATE_CONTROL_FORCE_UNIT_ACCESS_ON_SOFT_CAP,
}
