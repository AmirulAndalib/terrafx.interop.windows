// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PSHNOTIFY.xml' path='doc/member[@name="PSHNOTIFY"]/*' />
public partial struct PSHNOTIFY
{
    /// <include file='PSHNOTIFY.xml' path='doc/member[@name="PSHNOTIFY.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='PSHNOTIFY.xml' path='doc/member[@name="PSHNOTIFY.lParam"]/*' />
    public LPARAM lParam;
}
