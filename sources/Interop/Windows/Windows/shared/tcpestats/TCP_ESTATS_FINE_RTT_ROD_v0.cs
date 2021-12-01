// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TCP_ESTATS_FINE_RTT_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_FINE_RTT_ROD_v0"]/*' />
public partial struct TCP_ESTATS_FINE_RTT_ROD_v0
{
    /// <include file='TCP_ESTATS_FINE_RTT_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_FINE_RTT_ROD_v0.RttVar"]/*' />
    [NativeTypeName("ULONG")]
    public uint RttVar;

    /// <include file='TCP_ESTATS_FINE_RTT_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_FINE_RTT_ROD_v0.MaxRtt"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxRtt;

    /// <include file='TCP_ESTATS_FINE_RTT_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_FINE_RTT_ROD_v0.MinRtt"]/*' />
    [NativeTypeName("ULONG")]
    public uint MinRtt;

    /// <include file='TCP_ESTATS_FINE_RTT_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_FINE_RTT_ROD_v0.SumRtt"]/*' />
    [NativeTypeName("ULONG")]
    public uint SumRtt;
}
