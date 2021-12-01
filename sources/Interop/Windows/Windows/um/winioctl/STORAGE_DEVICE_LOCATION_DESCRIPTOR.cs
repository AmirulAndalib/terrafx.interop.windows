// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_DEVICE_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_LOCATION_DESCRIPTOR"]/*' />
public partial struct STORAGE_DEVICE_LOCATION_DESCRIPTOR
{
    /// <include file='STORAGE_DEVICE_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_LOCATION_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_DEVICE_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_LOCATION_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_DEVICE_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_LOCATION_DESCRIPTOR.Location"]/*' />
    public DEVICE_LOCATION Location;

    /// <include file='STORAGE_DEVICE_LOCATION_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_LOCATION_DESCRIPTOR.StringOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint StringOffset;
}
