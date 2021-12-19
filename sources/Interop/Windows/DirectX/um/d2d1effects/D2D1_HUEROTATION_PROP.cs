// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_HUEROTATION_PROP.xml' path='doc/member[@name="D2D1_HUEROTATION_PROP"]/*' />
public enum D2D1_HUEROTATION_PROP : uint
{
    /// <include file='D2D1_HUEROTATION_PROP.xml' path='doc/member[@name="D2D1_HUEROTATION_PROP.D2D1_HUEROTATION_PROP_ANGLE"]/*' />
    D2D1_HUEROTATION_PROP_ANGLE = 0,

    /// <include file='D2D1_HUEROTATION_PROP.xml' path='doc/member[@name="D2D1_HUEROTATION_PROP.D2D1_HUEROTATION_PROP_FORCE_DWORD"]/*' />
    D2D1_HUEROTATION_PROP_FORCE_DWORD = 0xffffffff,
}
