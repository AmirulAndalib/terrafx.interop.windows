// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE"]/*' />
public enum DML_ROUNDING_MODE
{
    /// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE.DML_ROUNDING_MODE_HALVES_TO_NEAREST_EVEN"]/*' />
    DML_ROUNDING_MODE_HALVES_TO_NEAREST_EVEN,

    /// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE.DML_ROUNDING_MODE_TOWARD_ZERO"]/*' />
    DML_ROUNDING_MODE_TOWARD_ZERO,

    /// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE.DML_ROUNDING_MODE_TOWARD_INFINITY"]/*' />
    DML_ROUNDING_MODE_TOWARD_INFINITY,
}
