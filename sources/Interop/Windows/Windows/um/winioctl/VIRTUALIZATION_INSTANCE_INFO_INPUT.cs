// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT"]/*' />
public partial struct VIRTUALIZATION_INSTANCE_INFO_INPUT
{
    /// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT.NumberOfWorkerThreads"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfWorkerThreads;

    /// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
