// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='KERB_RETRIEVE_TKT_RESPONSE.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_RESPONSE"]/*' />
public partial struct KERB_RETRIEVE_TKT_RESPONSE
{
    /// <include file='KERB_RETRIEVE_TKT_RESPONSE.xml' path='doc/member[@name="KERB_RETRIEVE_TKT_RESPONSE.Ticket"]/*' />
    public KERB_EXTERNAL_TICKET Ticket;
}
