// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE"]/*' />
[Flags]
public enum IMAPI_FORMAT2_DATA_MEDIA_STATE
{
    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_UNKNOWN"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_UNKNOWN = 0,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_INFORMATIONAL_MASK"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_INFORMATIONAL_MASK = 0xf,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_UNSUPPORTED_MASK"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_UNSUPPORTED_MASK = 0xfc00,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_OVERWRITE_ONLY"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_OVERWRITE_ONLY = 0x1,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_RANDOMLY_WRITABLE"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_RANDOMLY_WRITABLE = 0x1,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_BLANK"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_BLANK = 0x2,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_APPENDABLE"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_APPENDABLE = 0x4,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_FINAL_SESSION"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_FINAL_SESSION = 0x8,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_DAMAGED"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_DAMAGED = 0x400,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_ERASE_REQUIRED"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_ERASE_REQUIRED = 0x800,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_NON_EMPTY_SESSION"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_NON_EMPTY_SESSION = 0x1000,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_WRITE_PROTECTED"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_WRITE_PROTECTED = 0x2000,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_FINALIZED"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_FINALIZED = 0x4000,

    /// <include file='IMAPI_FORMAT2_DATA_MEDIA_STATE.xml' path='doc/member[@name="IMAPI_FORMAT2_DATA_MEDIA_STATE.IMAPI_FORMAT2_DATA_MEDIA_STATE_UNSUPPORTED_MEDIA"]/*' />
    IMAPI_FORMAT2_DATA_MEDIA_STATE_UNSUPPORTED_MEDIA = 0x8000,
}
