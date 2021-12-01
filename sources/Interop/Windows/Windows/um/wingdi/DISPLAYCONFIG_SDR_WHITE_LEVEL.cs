// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_SDR_WHITE_LEVEL.xml' path='doc/member[@name="DISPLAYCONFIG_SDR_WHITE_LEVEL"]/*' />
public partial struct DISPLAYCONFIG_SDR_WHITE_LEVEL
{
    /// <include file='DISPLAYCONFIG_SDR_WHITE_LEVEL.xml' path='doc/member[@name="DISPLAYCONFIG_SDR_WHITE_LEVEL.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_SDR_WHITE_LEVEL.xml' path='doc/member[@name="DISPLAYCONFIG_SDR_WHITE_LEVEL.SDRWhiteLevel"]/*' />
    [NativeTypeName("ULONG")]
    public uint SDRWhiteLevel;
}
