// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS"]/*' />
public enum MFMEDIASOURCE_CHARACTERISTICS
{
    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_IS_LIVE"]/*' />
    MFMEDIASOURCE_IS_LIVE = 0x1,

    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_CAN_SEEK"]/*' />
    MFMEDIASOURCE_CAN_SEEK = 0x2,

    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_CAN_PAUSE"]/*' />
    MFMEDIASOURCE_CAN_PAUSE = 0x4,

    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_HAS_SLOW_SEEK"]/*' />
    MFMEDIASOURCE_HAS_SLOW_SEEK = 0x8,

    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_HAS_MULTIPLE_PRESENTATIONS"]/*' />
    MFMEDIASOURCE_HAS_MULTIPLE_PRESENTATIONS = 0x10,

    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_CAN_SKIPFORWARD"]/*' />
    MFMEDIASOURCE_CAN_SKIPFORWARD = 0x20,

    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_CAN_SKIPBACKWARD"]/*' />
    MFMEDIASOURCE_CAN_SKIPBACKWARD = 0x40,

    /// <include file='MFMEDIASOURCE_CHARACTERISTICS.xml' path='doc/member[@name="MFMEDIASOURCE_CHARACTERISTICS.MFMEDIASOURCE_DOES_NOT_USE_NETWORK"]/*' />
    MFMEDIASOURCE_DOES_NOT_USE_NETWORK = 0x80,
}
