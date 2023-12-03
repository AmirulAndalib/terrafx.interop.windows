// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct DEVICE_POWER_DESCRIPTOR
{
    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.DeviceAttentionSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte DeviceAttentionSupported;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.AsynchronousNotificationSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte AsynchronousNotificationSupported;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.IdlePowerManagementEnabled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte IdlePowerManagementEnabled;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.D3ColdEnabled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte D3ColdEnabled;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.D3ColdSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte D3ColdSupported;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.NoVerifyDuringIdlePower"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte NoVerifyDuringIdlePower;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.Reserved"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='DEVICE_POWER_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_POWER_DESCRIPTOR.IdleTimeoutInMS"]/*' />
    [NativeTypeName("DWORD")]
    public uint IdleTimeoutInMS;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
