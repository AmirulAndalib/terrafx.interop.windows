// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='JOBOBJECT_NETWORK_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NETWORK_ACCOUNTING_INFORMATION"]/*' />
public partial struct JOBOBJECT_NETWORK_ACCOUNTING_INFORMATION
{
    /// <include file='JOBOBJECT_NETWORK_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NETWORK_ACCOUNTING_INFORMATION.DataBytesIn"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong DataBytesIn;

    /// <include file='JOBOBJECT_NETWORK_ACCOUNTING_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_NETWORK_ACCOUNTING_INFORMATION.DataBytesOut"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong DataBytesOut;
}
