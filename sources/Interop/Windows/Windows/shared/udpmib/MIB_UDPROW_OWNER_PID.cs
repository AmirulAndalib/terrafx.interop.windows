// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MIB_UDPROW_OWNER_PID.xml' path='doc/member[@name="MIB_UDPROW_OWNER_PID"]/*' />
public partial struct MIB_UDPROW_OWNER_PID
{
    /// <include file='MIB_UDPROW_OWNER_PID.xml' path='doc/member[@name="MIB_UDPROW_OWNER_PID.dwLocalAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;

    /// <include file='MIB_UDPROW_OWNER_PID.xml' path='doc/member[@name="MIB_UDPROW_OWNER_PID.dwLocalPort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    /// <include file='MIB_UDPROW_OWNER_PID.xml' path='doc/member[@name="MIB_UDPROW_OWNER_PID.dwOwningPid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
}
