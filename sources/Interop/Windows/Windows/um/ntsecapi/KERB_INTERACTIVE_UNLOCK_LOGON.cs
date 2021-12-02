// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='KERB_INTERACTIVE_UNLOCK_LOGON.xml' path='doc/member[@name="KERB_INTERACTIVE_UNLOCK_LOGON"]/*' />
public partial struct KERB_INTERACTIVE_UNLOCK_LOGON
{
    /// <include file='KERB_INTERACTIVE_UNLOCK_LOGON.xml' path='doc/member[@name="KERB_INTERACTIVE_UNLOCK_LOGON.Logon"]/*' />
    public KERB_INTERACTIVE_LOGON Logon;

    /// <include file='KERB_INTERACTIVE_UNLOCK_LOGON.xml' path='doc/member[@name="KERB_INTERACTIVE_UNLOCK_LOGON.LogonId"]/*' />
    public LUID LogonId;
}
