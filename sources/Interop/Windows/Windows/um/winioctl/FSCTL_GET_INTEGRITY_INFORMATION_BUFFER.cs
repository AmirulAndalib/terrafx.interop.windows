// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.xml' path='doc/member[@name="FSCTL_GET_INTEGRITY_INFORMATION_BUFFER"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct FSCTL_GET_INTEGRITY_INFORMATION_BUFFER
{
    /// <include file='FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.xml' path='doc/member[@name="FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.ChecksumAlgorithm"]/*' />
    [NativeTypeName("WORD")]
    public ushort ChecksumAlgorithm;

    /// <include file='FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.xml' path='doc/member[@name="FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.xml' path='doc/member[@name="FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.xml' path='doc/member[@name="FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.ChecksumChunkSizeInBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint ChecksumChunkSizeInBytes;

    /// <include file='FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.xml' path='doc/member[@name="FSCTL_GET_INTEGRITY_INFORMATION_BUFFER.ClusterSizeInBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint ClusterSizeInBytes;
}
