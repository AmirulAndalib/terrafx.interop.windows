// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IMAPI_FEATURE_PAGE_TYPE
    {
        IMAPI_FEATURE_PAGE_TYPE_PROFILE_LIST = 0,
        IMAPI_FEATURE_PAGE_TYPE_CORE = 0x1,
        IMAPI_FEATURE_PAGE_TYPE_MORPHING = 0x2,
        IMAPI_FEATURE_PAGE_TYPE_REMOVABLE_MEDIUM = 0x3,
        IMAPI_FEATURE_PAGE_TYPE_WRITE_PROTECT = 0x4,
        IMAPI_FEATURE_PAGE_TYPE_RANDOMLY_READABLE = 0x10,
        IMAPI_FEATURE_PAGE_TYPE_CD_MULTIREAD = 0x1d,
        IMAPI_FEATURE_PAGE_TYPE_CD_READ = 0x1e,
        IMAPI_FEATURE_PAGE_TYPE_DVD_READ = 0x1f,
        IMAPI_FEATURE_PAGE_TYPE_RANDOMLY_WRITABLE = 0x20,
        IMAPI_FEATURE_PAGE_TYPE_INCREMENTAL_STREAMING_WRITABLE = 0x21,
        IMAPI_FEATURE_PAGE_TYPE_SECTOR_ERASABLE = 0x22,
        IMAPI_FEATURE_PAGE_TYPE_FORMATTABLE = 0x23,
        IMAPI_FEATURE_PAGE_TYPE_HARDWARE_DEFECT_MANAGEMENT = 0x24,
        IMAPI_FEATURE_PAGE_TYPE_WRITE_ONCE = 0x25,
        IMAPI_FEATURE_PAGE_TYPE_RESTRICTED_OVERWRITE = 0x26,
        IMAPI_FEATURE_PAGE_TYPE_CDRW_CAV_WRITE = 0x27,
        IMAPI_FEATURE_PAGE_TYPE_MRW = 0x28,
        IMAPI_FEATURE_PAGE_TYPE_ENHANCED_DEFECT_REPORTING = 0x29,
        IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_RW = 0x2a,
        IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_R = 0x2b,
        IMAPI_FEATURE_PAGE_TYPE_RIGID_RESTRICTED_OVERWRITE = 0x2c,
        IMAPI_FEATURE_PAGE_TYPE_CD_TRACK_AT_ONCE = 0x2d,
        IMAPI_FEATURE_PAGE_TYPE_CD_MASTERING = 0x2e,
        IMAPI_FEATURE_PAGE_TYPE_DVD_DASH_WRITE = 0x2f,
        IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_READ = 0x30,
        IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_R_WRITE = 0x31,
        IMAPI_FEATURE_PAGE_TYPE_DOUBLE_DENSITY_CD_RW_WRITE = 0x32,
        IMAPI_FEATURE_PAGE_TYPE_LAYER_JUMP_RECORDING = 0x33,
        IMAPI_FEATURE_PAGE_TYPE_CD_RW_MEDIA_WRITE_SUPPORT = 0x37,
        IMAPI_FEATURE_PAGE_TYPE_BD_PSEUDO_OVERWRITE = 0x38,
        IMAPI_FEATURE_PAGE_TYPE_DVD_PLUS_R_DUAL_LAYER = 0x3b,
        IMAPI_FEATURE_PAGE_TYPE_BD_READ = 0x40,
        IMAPI_FEATURE_PAGE_TYPE_BD_WRITE = 0x41,
        IMAPI_FEATURE_PAGE_TYPE_HD_DVD_READ = 0x50,
        IMAPI_FEATURE_PAGE_TYPE_HD_DVD_WRITE = 0x51,
        IMAPI_FEATURE_PAGE_TYPE_POWER_MANAGEMENT = 0x100,
        IMAPI_FEATURE_PAGE_TYPE_SMART = 0x101,
        IMAPI_FEATURE_PAGE_TYPE_EMBEDDED_CHANGER = 0x102,
        IMAPI_FEATURE_PAGE_TYPE_CD_ANALOG_PLAY = 0x103,
        IMAPI_FEATURE_PAGE_TYPE_MICROCODE_UPDATE = 0x104,
        IMAPI_FEATURE_PAGE_TYPE_TIMEOUT = 0x105,
        IMAPI_FEATURE_PAGE_TYPE_DVD_CSS = 0x106,
        IMAPI_FEATURE_PAGE_TYPE_REAL_TIME_STREAMING = 0x107,
        IMAPI_FEATURE_PAGE_TYPE_LOGICAL_UNIT_SERIAL_NUMBER = 0x108,
        IMAPI_FEATURE_PAGE_TYPE_MEDIA_SERIAL_NUMBER = 0x109,
        IMAPI_FEATURE_PAGE_TYPE_DISC_CONTROL_BLOCKS = 0x10a,
        IMAPI_FEATURE_PAGE_TYPE_DVD_CPRM = 0x10b,
        IMAPI_FEATURE_PAGE_TYPE_FIRMWARE_INFORMATION = 0x10c,
        IMAPI_FEATURE_PAGE_TYPE_AACS = 0x10d,
        IMAPI_FEATURE_PAGE_TYPE_VCPS = 0x110,
    }
}