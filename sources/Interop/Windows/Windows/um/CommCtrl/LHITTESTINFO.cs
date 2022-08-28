// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='LHITTESTINFO.xml' path='doc/member[@name="LHITTESTINFO"]/*' />
public partial struct LHITTESTINFO
{
    /// <include file='LHITTESTINFO.xml' path='doc/member[@name="LHITTESTINFO.pt"]/*' />
    public POINT pt;

    /// <include file='LHITTESTINFO.xml' path='doc/member[@name="LHITTESTINFO.item"]/*' />
    public LITEM item;
}
