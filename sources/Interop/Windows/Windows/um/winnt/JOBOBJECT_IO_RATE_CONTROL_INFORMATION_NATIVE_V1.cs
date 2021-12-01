// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1"]/*' />
public unsafe partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1
{
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.MaxIops"]/*' />
    [NativeTypeName("LONG64")]
    public long MaxIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.MaxBandwidth"]/*' />
    [NativeTypeName("LONG64")]
    public long MaxBandwidth;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.ReservationIops"]/*' />
    [NativeTypeName("LONG64")]
    public long ReservationIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.VolumeName"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* VolumeName;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.BaseIoSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint BaseIoSize;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.ControlFlags"]/*' />
    public JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V1.VolumeNameLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort VolumeNameLength;
}
