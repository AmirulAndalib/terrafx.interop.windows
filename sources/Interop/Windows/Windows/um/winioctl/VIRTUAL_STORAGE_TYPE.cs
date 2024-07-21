// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='VIRTUAL_STORAGE_TYPE.xml' path='doc/member[@name="VIRTUAL_STORAGE_TYPE"]/*' />
public partial struct VIRTUAL_STORAGE_TYPE
{
    /// <include file='VIRTUAL_STORAGE_TYPE.xml' path='doc/member[@name="VIRTUAL_STORAGE_TYPE.DeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceId;

    /// <include file='VIRTUAL_STORAGE_TYPE.xml' path='doc/member[@name="VIRTUAL_STORAGE_TYPE.VendorId"]/*' />
    public Guid VendorId;
}
