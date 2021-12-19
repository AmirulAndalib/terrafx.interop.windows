// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WICDdsAlphaMode.xml' path='doc/member[@name="WICDdsAlphaMode"]/*' />
[SupportedOSPlatform("windows8.1")]
public enum WICDdsAlphaMode
{
    /// <include file='WICDdsAlphaMode.xml' path='doc/member[@name="WICDdsAlphaMode.WICDdsAlphaModeUnknown"]/*' />
    WICDdsAlphaModeUnknown = 0,

    /// <include file='WICDdsAlphaMode.xml' path='doc/member[@name="WICDdsAlphaMode.WICDdsAlphaModeStraight"]/*' />
    WICDdsAlphaModeStraight = 0x1,

    /// <include file='WICDdsAlphaMode.xml' path='doc/member[@name="WICDdsAlphaMode.WICDdsAlphaModePremultiplied"]/*' />
    WICDdsAlphaModePremultiplied = 0x2,

    /// <include file='WICDdsAlphaMode.xml' path='doc/member[@name="WICDdsAlphaMode.WICDdsAlphaModeOpaque"]/*' />
    WICDdsAlphaModeOpaque = 0x3,

    /// <include file='WICDdsAlphaMode.xml' path='doc/member[@name="WICDdsAlphaMode.WICDdsAlphaModeCustom"]/*' />
    WICDdsAlphaModeCustom = 0x4,

    /// <include file='WICDdsAlphaMode.xml' path='doc/member[@name="WICDdsAlphaMode.WICDDSALPHAMODE_FORCE_DWORD"]/*' />
    WICDDSALPHAMODE_FORCE_DWORD = 0x7fffffff,
}
