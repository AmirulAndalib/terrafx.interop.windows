// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HD_TEXTFILTERW.xml' path='doc/member[@name="HD_TEXTFILTERW"]/*' />
public unsafe partial struct HD_TEXTFILTERW
{
    /// <include file='HD_TEXTFILTERW.xml' path='doc/member[@name="HD_TEXTFILTERW.pszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;

    /// <include file='HD_TEXTFILTERW.xml' path='doc/member[@name="HD_TEXTFILTERW.cchTextMax"]/*' />
    public int cchTextMax;
}
