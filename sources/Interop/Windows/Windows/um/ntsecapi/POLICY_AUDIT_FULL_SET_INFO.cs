// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='POLICY_AUDIT_FULL_SET_INFO.xml' path='doc/member[@name="POLICY_AUDIT_FULL_SET_INFO"]/*' />
public partial struct POLICY_AUDIT_FULL_SET_INFO
{
    /// <include file='POLICY_AUDIT_FULL_SET_INFO.xml' path='doc/member[@name="POLICY_AUDIT_FULL_SET_INFO.ShutDownOnFull"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ShutDownOnFull;
}
