// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WICPngBkgdProperties.xml' path='doc/member[@name="WICPngBkgdProperties"]/*' />
public enum WICPngBkgdProperties : uint
{
    /// <include file='WICPngBkgdProperties.xml' path='doc/member[@name="WICPngBkgdProperties.WICPngBkgdBackgroundColor"]/*' />
    WICPngBkgdBackgroundColor = 0x1,

    /// <include file='WICPngBkgdProperties.xml' path='doc/member[@name="WICPngBkgdProperties.WICPngBkgdProperties_FORCE_DWORD"]/*' />
    WICPngBkgdProperties_FORCE_DWORD = 0x7fffffff,
}
