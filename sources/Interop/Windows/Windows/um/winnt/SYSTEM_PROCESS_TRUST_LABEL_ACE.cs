// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_PROCESS_TRUST_LABEL_ACE.xml' path='doc/member[@name="SYSTEM_PROCESS_TRUST_LABEL_ACE"]/*' />
public partial struct SYSTEM_PROCESS_TRUST_LABEL_ACE
{
    /// <include file='SYSTEM_PROCESS_TRUST_LABEL_ACE.xml' path='doc/member[@name="SYSTEM_PROCESS_TRUST_LABEL_ACE.Header"]/*' />
    public ACE_HEADER Header;

    /// <include file='SYSTEM_PROCESS_TRUST_LABEL_ACE.xml' path='doc/member[@name="SYSTEM_PROCESS_TRUST_LABEL_ACE.Mask"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint Mask;

    /// <include file='SYSTEM_PROCESS_TRUST_LABEL_ACE.xml' path='doc/member[@name="SYSTEM_PROCESS_TRUST_LABEL_ACE.SidStart"]/*' />
    [NativeTypeName("DWORD")]
    public uint SidStart;
}
