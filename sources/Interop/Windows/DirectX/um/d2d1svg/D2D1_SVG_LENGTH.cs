// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_SVG_LENGTH.xml' path='doc/member[@name="D2D1_SVG_LENGTH"]/*' />
public partial struct D2D1_SVG_LENGTH
{
    /// <include file='D2D1_SVG_LENGTH.xml' path='doc/member[@name="D2D1_SVG_LENGTH.value"]/*' />
    public float value;

    /// <include file='D2D1_SVG_LENGTH.xml' path='doc/member[@name="D2D1_SVG_LENGTH.units"]/*' />
    public D2D1_SVG_LENGTH_UNITS units;
}
