// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA"]/*' />
public unsafe partial struct ADDRINFOA
{
    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_flags"]/*' />
    public int ai_flags;

    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_family"]/*' />
    public int ai_family;

    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_socktype"]/*' />
    public int ai_socktype;

    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_protocol"]/*' />
    public int ai_protocol;

    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_addrlen"]/*' />
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;

    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_canonname"]/*' />
    [NativeTypeName("char *")]
    public sbyte* ai_canonname;

    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_addr"]/*' />
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;

    /// <include file='ADDRINFOA.xml' path='doc/member[@name="ADDRINFOA.ai_next"]/*' />
    [NativeTypeName("struct addrinfo *")]
    public ADDRINFOA* ai_next;
}
