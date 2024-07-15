// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCM_LOGICAL_DEVICES.xml' path='doc/member[@name="SCM_LOGICAL_DEVICES"]/*' />
public partial struct SCM_LOGICAL_DEVICES
{
    /// <include file='SCM_LOGICAL_DEVICES.xml' path='doc/member[@name="SCM_LOGICAL_DEVICES.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_LOGICAL_DEVICES.xml' path='doc/member[@name="SCM_LOGICAL_DEVICES.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_LOGICAL_DEVICES.xml' path='doc/member[@name="SCM_LOGICAL_DEVICES.DeviceCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceCount;

    /// <include file='SCM_LOGICAL_DEVICES.xml' path='doc/member[@name="SCM_LOGICAL_DEVICES.Devices"]/*' />
    [NativeTypeName("SCM_LOGICAL_DEVICE_INSTANCE[1]")]
    public _Devices_e__FixedBuffer Devices;

    /// <include file='_Devices_e__FixedBuffer.xml' path='doc/member[@name="_Devices_e__FixedBuffer"]/*' />
    public partial struct _Devices_e__FixedBuffer
    {
        public SCM_LOGICAL_DEVICE_INSTANCE e0;

        [UnscopedRef]
        public ref SCM_LOGICAL_DEVICE_INSTANCE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_LOGICAL_DEVICE_INSTANCE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
