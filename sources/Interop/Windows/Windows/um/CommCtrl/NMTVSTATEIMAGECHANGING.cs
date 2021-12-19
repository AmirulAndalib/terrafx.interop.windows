// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NMTVSTATEIMAGECHANGING.xml' path='doc/member[@name="NMTVSTATEIMAGECHANGING"]/*' />
public partial struct NMTVSTATEIMAGECHANGING
{
    /// <include file='NMTVSTATEIMAGECHANGING.xml' path='doc/member[@name="NMTVSTATEIMAGECHANGING.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTVSTATEIMAGECHANGING.xml' path='doc/member[@name="NMTVSTATEIMAGECHANGING.hti"]/*' />
    public HTREEITEM hti;

    /// <include file='NMTVSTATEIMAGECHANGING.xml' path='doc/member[@name="NMTVSTATEIMAGECHANGING.iOldStateImageIndex"]/*' />
    public int iOldStateImageIndex;

    /// <include file='NMTVSTATEIMAGECHANGING.xml' path='doc/member[@name="NMTVSTATEIMAGECHANGING.iNewStateImageIndex"]/*' />
    public int iNewStateImageIndex;
}
