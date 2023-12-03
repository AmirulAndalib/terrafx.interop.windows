// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.xml' path='doc/member[@name="FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX"]/*' />
public partial struct FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX
{
    /// <include file='FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.xml' path='doc/member[@name="FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.EnableIntegrity"]/*' />
    public byte EnableIntegrity;

    /// <include file='FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.xml' path='doc/member[@name="FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.KeepIntegrityStateUnchanged"]/*' />
    public byte KeepIntegrityStateUnchanged;

    /// <include file='FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.xml' path='doc/member[@name="FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.xml' path='doc/member[@name="FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.xml' path='doc/member[@name="FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.Version"]/*' />
    public byte Version;

    /// <include file='FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.xml' path='doc/member[@name="FSCTL_SET_INTEGRITY_INFORMATION_BUFFER_EX.Reserved2"]/*' />
    [NativeTypeName("BYTE[7]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    [InlineArray(7)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public byte e0;
    }
}
