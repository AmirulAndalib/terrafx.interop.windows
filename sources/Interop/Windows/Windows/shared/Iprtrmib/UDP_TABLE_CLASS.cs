// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='UDP_TABLE_CLASS.xml' path='doc/member[@name="UDP_TABLE_CLASS"]/*' />
public enum UDP_TABLE_CLASS
{
    /// <include file='UDP_TABLE_CLASS.xml' path='doc/member[@name="UDP_TABLE_CLASS.UDP_TABLE_BASIC"]/*' />
    UDP_TABLE_BASIC,

    /// <include file='UDP_TABLE_CLASS.xml' path='doc/member[@name="UDP_TABLE_CLASS.UDP_TABLE_OWNER_PID"]/*' />
    UDP_TABLE_OWNER_PID,

    /// <include file='UDP_TABLE_CLASS.xml' path='doc/member[@name="UDP_TABLE_CLASS.UDP_TABLE_OWNER_MODULE"]/*' />
    UDP_TABLE_OWNER_MODULE,
}
