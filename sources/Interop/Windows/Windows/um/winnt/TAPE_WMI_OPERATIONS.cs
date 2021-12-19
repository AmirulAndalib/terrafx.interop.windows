// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TAPE_WMI_OPERATIONS.xml' path='doc/member[@name="TAPE_WMI_OPERATIONS"]/*' />
public unsafe partial struct TAPE_WMI_OPERATIONS
{
    /// <include file='TAPE_WMI_OPERATIONS.xml' path='doc/member[@name="TAPE_WMI_OPERATIONS.Method"]/*' />
    [NativeTypeName("DWORD")]
    public uint Method;

    /// <include file='TAPE_WMI_OPERATIONS.xml' path='doc/member[@name="TAPE_WMI_OPERATIONS.DataBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataBufferSize;

    /// <include file='TAPE_WMI_OPERATIONS.xml' path='doc/member[@name="TAPE_WMI_OPERATIONS.DataBuffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* DataBuffer;
}
