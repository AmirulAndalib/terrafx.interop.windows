// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='DEVPROPKEY.xml' path='doc/member[@name="DEVPROPKEY"]/*' />
public partial struct DEVPROPKEY
{
    /// <include file='DEVPROPKEY.xml' path='doc/member[@name="DEVPROPKEY.fmtid"]/*' />
    [NativeTypeName("DEVPROPGUID")]
    public Guid fmtid;

    /// <include file='DEVPROPKEY.xml' path='doc/member[@name="DEVPROPKEY.pid"]/*' />
    [NativeTypeName("DEVPROPID")]
    public uint pid;
}
