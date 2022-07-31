// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='KERB_QUERY_TKT_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_RESPONSE"]/*' />
public partial struct KERB_QUERY_TKT_CACHE_RESPONSE
{
    /// <include file='KERB_QUERY_TKT_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_RESPONSE.MessageType"]/*' />
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;

    /// <include file='KERB_QUERY_TKT_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_RESPONSE.CountOfTickets"]/*' />
    [NativeTypeName("ULONG")]
    public uint CountOfTickets;

    /// <include file='KERB_QUERY_TKT_CACHE_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_RESPONSE.Tickets"]/*' />
    [NativeTypeName("KERB_TICKET_CACHE_INFO[1]")]
    public _Tickets_e__FixedBuffer Tickets;

    /// <include file='_Tickets_e__FixedBuffer.xml' path='doc/member[@name="_Tickets_e__FixedBuffer"]/*' />
    public partial struct _Tickets_e__FixedBuffer
    {
        public KERB_TICKET_CACHE_INFO e0;

        public ref KERB_TICKET_CACHE_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<KERB_TICKET_CACHE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
