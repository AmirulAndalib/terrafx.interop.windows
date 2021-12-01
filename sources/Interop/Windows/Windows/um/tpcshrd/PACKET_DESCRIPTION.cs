// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='PACKET_DESCRIPTION.xml' path='doc/member[@name="PACKET_DESCRIPTION"]/*' />
public unsafe partial struct PACKET_DESCRIPTION
{
    /// <include file='PACKET_DESCRIPTION.xml' path='doc/member[@name="PACKET_DESCRIPTION.cbPacketSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbPacketSize;

    /// <include file='PACKET_DESCRIPTION.xml' path='doc/member[@name="PACKET_DESCRIPTION.cPacketProperties"]/*' />
    [NativeTypeName("ULONG")]
    public uint cPacketProperties;

    /// <include file='PACKET_DESCRIPTION.xml' path='doc/member[@name="PACKET_DESCRIPTION.pPacketProperties"]/*' />
    public PACKET_PROPERTY* pPacketProperties;

    /// <include file='PACKET_DESCRIPTION.xml' path='doc/member[@name="PACKET_DESCRIPTION.cButtons"]/*' />
    [NativeTypeName("ULONG")]
    public uint cButtons;

    /// <include file='PACKET_DESCRIPTION.xml' path='doc/member[@name="PACKET_DESCRIPTION.pguidButtons"]/*' />
    public Guid* pguidButtons;
}
