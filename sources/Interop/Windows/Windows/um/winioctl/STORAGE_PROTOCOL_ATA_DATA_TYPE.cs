// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_PROTOCOL_ATA_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_ATA_DATA_TYPE"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum STORAGE_PROTOCOL_ATA_DATA_TYPE
{
    /// <include file='STORAGE_PROTOCOL_ATA_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_ATA_DATA_TYPE.AtaDataTypeUnknown"]/*' />
    AtaDataTypeUnknown = 0,

    /// <include file='STORAGE_PROTOCOL_ATA_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_ATA_DATA_TYPE.AtaDataTypeIdentify"]/*' />
    AtaDataTypeIdentify,

    /// <include file='STORAGE_PROTOCOL_ATA_DATA_TYPE.xml' path='doc/member[@name="STORAGE_PROTOCOL_ATA_DATA_TYPE.AtaDataTypeLogPage"]/*' />
    AtaDataTypeLogPage,
}
