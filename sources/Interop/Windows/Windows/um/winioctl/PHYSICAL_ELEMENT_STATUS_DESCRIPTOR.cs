// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR"]/*' />
public partial struct PHYSICAL_ELEMENT_STATUS_DESCRIPTOR
{
    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.ElementIdentifier"]/*' />
    [NativeTypeName("DWORD")]
    public uint ElementIdentifier;

    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.PhysicalElementType"]/*' />
    public byte PhysicalElementType;

    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.PhysicalElementHealth"]/*' />
    public byte PhysicalElementHealth;

    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.Reserved1"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.AssociatedCapacity"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong AssociatedCapacity;

    /// <include file='PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.xml' path='doc/member[@name="PHYSICAL_ELEMENT_STATUS_DESCRIPTOR.Reserved2"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public uint e0;
    }
}
