// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WICPlanarOptions.xml' path='doc/member[@name="WICPlanarOptions"]/*' />
[SupportedOSPlatform("windows8.1")]
public enum WICPlanarOptions
{
    /// <include file='WICPlanarOptions.xml' path='doc/member[@name="WICPlanarOptions.WICPlanarOptionsDefault"]/*' />
    WICPlanarOptionsDefault = 0,

    /// <include file='WICPlanarOptions.xml' path='doc/member[@name="WICPlanarOptions.WICPlanarOptionsPreserveSubsampling"]/*' />
    WICPlanarOptionsPreserveSubsampling = 0x1,

    /// <include file='WICPlanarOptions.xml' path='doc/member[@name="WICPlanarOptions.WICPLANAROPTIONS_FORCE_DWORD"]/*' />
    WICPLANAROPTIONS_FORCE_DWORD = 0x7fffffff,
}
