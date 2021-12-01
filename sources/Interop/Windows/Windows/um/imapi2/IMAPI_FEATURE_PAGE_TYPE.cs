// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE"]/*' />
public enum IMAPI_FEATURE_PAGE_TYPE
{
    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_PROFILE_LIST"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_PROFILE_LIST = 0,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CORE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CORE = 0x1,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_MORPHING"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_MORPHING = 0x2,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_REMOVABLE_MEDIUM"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_REMOVABLE_MEDIUM = 0x3,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_WRITE_PROTECT"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_WRITE_PROTECT = 0x4,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_RANDOMLY_READABLE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_RANDOMLY_READABLE = 0x10,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CD_MULTIREAD"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CD_MULTIREAD = 0x1d,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CD_READ"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CD_READ = 0x1e,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DVD_READ"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DVD_READ = 0x1f,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_RANDOMLY_WRITABLE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_RANDOMLY_WRITABLE = 0x20,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_INCREMENTAL_STREAMING_WRITABLE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_INCREMENTAL_STREAMING_WRITABLE = 0x21,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_SECTOR_ERASABLE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_SECTOR_ERASABLE = 0x22,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_FORMATTABLE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_FORMATTABLE = 0x23,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_HARDWARE_DEFECT_MANAGEMENT"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_HARDWARE_DEFECT_MANAGEMENT = 0x24,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_WRITE_ONCE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_WRITE_ONCE = 0x25,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_RESTRICTED_OVERWRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_RESTRICTED_OVERWRITE = 0x26,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CDRW_CAV_WRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CDRW_CAV_WRITE = 0x27,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_MRW"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_MRW = 0x28,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_ENHANCED_DEFECT_REPORTING"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_ENHANCED_DEFECT_REPORTING = 0x29,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_RW"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_RW = 0x2a,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_R"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_R = 0x2b,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_RIGID_RESTRICTED_OVERWRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_RIGID_RESTRICTED_OVERWRITE = 0x2c,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CD_TRACK_AT_ONCE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CD_TRACK_AT_ONCE = 0x2d,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CD_MASTERING"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CD_MASTERING = 0x2e,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DVD_DASH_WRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DVD_DASH_WRITE = 0x2f,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_READ"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_READ = 0x30,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_R_WRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_R_WRITE = 0x31,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_RW_WRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_RW_WRITE = 0x32,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_LAYER_JUMP_RECORDING"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_LAYER_JUMP_RECORDING = 0x33,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CD_RW_MEDIA_WRITE_SUPPORT"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CD_RW_MEDIA_WRITE_SUPPORT = 0x37,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_BD_PSEUDO_OVERWRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_BD_PSEUDO_OVERWRITE = 0x38,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_R_DUAL_LAYER"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_R_DUAL_LAYER = 0x3b,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_BD_READ"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_BD_READ = 0x40,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_BD_WRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_BD_WRITE = 0x41,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_HD_DVD_READ"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_HD_DVD_READ = 0x50,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_HD_DVD_WRITE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_HD_DVD_WRITE = 0x51,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_POWER_MANAGEMENT"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_POWER_MANAGEMENT = 0x100,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_SMART"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_SMART = 0x101,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_EMBEDDED_CHANGER"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_EMBEDDED_CHANGER = 0x102,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_CD_ANALOG_PLAY"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_CD_ANALOG_PLAY = 0x103,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_MICROCODE_UPDATE"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_MICROCODE_UPDATE = 0x104,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_TIMEOUT"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_TIMEOUT = 0x105,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DVD_CSS"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DVD_CSS = 0x106,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_REAL_TIME_STREAMING"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_REAL_TIME_STREAMING = 0x107,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_LOGICAL_UNIT_SERIAL_NUMBER"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_LOGICAL_UNIT_SERIAL_NUMBER = 0x108,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_MEDIA_SERIAL_NUMBER"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_MEDIA_SERIAL_NUMBER = 0x109,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DISC_CONTROL_BLOCKS"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DISC_CONTROL_BLOCKS = 0x10a,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_DVD_CPRM"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_DVD_CPRM = 0x10b,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_FIRMWARE_INFORMATION"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_FIRMWARE_INFORMATION = 0x10c,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_AACS"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_AACS = 0x10d,

    /// <include file='IMAPI_FEATURE_PAGE_TYPE.xml' path='doc/member[@name="IMAPI_FEATURE_PAGE_TYPE.IMAPI_FEATURE_PAGE_TYPE_VCPS"]/*' />
    IMAPI_FEATURE_PAGE_TYPE_VCPS = 0x110,
}
