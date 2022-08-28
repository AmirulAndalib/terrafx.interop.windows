// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using static TerraFX.Interop.DirectX.DWRITE_RENDERING_MODE;

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum DWRITE_RENDERING_MODE1
{
    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_DEFAULT"]/*' />
    DWRITE_RENDERING_MODE1_DEFAULT = DWRITE_RENDERING_MODE_DEFAULT,

    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_ALIASED"]/*' />
    DWRITE_RENDERING_MODE1_ALIASED = DWRITE_RENDERING_MODE_ALIASED,

    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_GDI_CLASSIC"]/*' />
    DWRITE_RENDERING_MODE1_GDI_CLASSIC = DWRITE_RENDERING_MODE_GDI_CLASSIC,

    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_GDI_NATURAL"]/*' />
    DWRITE_RENDERING_MODE1_GDI_NATURAL = DWRITE_RENDERING_MODE_GDI_NATURAL,

    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_NATURAL"]/*' />
    DWRITE_RENDERING_MODE1_NATURAL = DWRITE_RENDERING_MODE_NATURAL,

    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC"]/*' />
    DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC = DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC,

    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_OUTLINE"]/*' />
    DWRITE_RENDERING_MODE1_OUTLINE = DWRITE_RENDERING_MODE_OUTLINE,

    /// <include file='DWRITE_RENDERING_MODE1.xml' path='doc/member[@name="DWRITE_RENDERING_MODE1.DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC_DOWNSAMPLED"]/*' />
    DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC_DOWNSAMPLED,
}
