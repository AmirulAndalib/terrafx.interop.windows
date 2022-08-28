// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TOKEN_MANDATORY_POLICY.xml' path='doc/member[@name="TOKEN_MANDATORY_POLICY"]/*' />
public partial struct TOKEN_MANDATORY_POLICY
{
    /// <include file='TOKEN_MANDATORY_POLICY.xml' path='doc/member[@name="TOKEN_MANDATORY_POLICY.Policy"]/*' />
    [NativeTypeName("DWORD")]
    public uint Policy;
}
