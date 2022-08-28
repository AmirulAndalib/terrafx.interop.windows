// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_CHROMAKEY_PROP.xml' path='doc/member[@name="D2D1_CHROMAKEY_PROP"]/*' />
public enum D2D1_CHROMAKEY_PROP : uint
{
    /// <include file='D2D1_CHROMAKEY_PROP.xml' path='doc/member[@name="D2D1_CHROMAKEY_PROP.D2D1_CHROMAKEY_PROP_COLOR"]/*' />
    D2D1_CHROMAKEY_PROP_COLOR = 0,

    /// <include file='D2D1_CHROMAKEY_PROP.xml' path='doc/member[@name="D2D1_CHROMAKEY_PROP.D2D1_CHROMAKEY_PROP_TOLERANCE"]/*' />
    D2D1_CHROMAKEY_PROP_TOLERANCE = 1,

    /// <include file='D2D1_CHROMAKEY_PROP.xml' path='doc/member[@name="D2D1_CHROMAKEY_PROP.D2D1_CHROMAKEY_PROP_INVERT_ALPHA"]/*' />
    D2D1_CHROMAKEY_PROP_INVERT_ALPHA = 2,

    /// <include file='D2D1_CHROMAKEY_PROP.xml' path='doc/member[@name="D2D1_CHROMAKEY_PROP.D2D1_CHROMAKEY_PROP_FEATHER"]/*' />
    D2D1_CHROMAKEY_PROP_FEATHER = 3,

    /// <include file='D2D1_CHROMAKEY_PROP.xml' path='doc/member[@name="D2D1_CHROMAKEY_PROP.D2D1_CHROMAKEY_PROP_FORCE_DWORD"]/*' />
    D2D1_CHROMAKEY_PROP_FORCE_DWORD = 0xffffffff,
}
