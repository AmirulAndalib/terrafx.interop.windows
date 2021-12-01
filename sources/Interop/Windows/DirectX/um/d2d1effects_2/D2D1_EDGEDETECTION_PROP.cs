// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_EDGEDETECTION_PROP.xml' path='doc/member[@name="D2D1_EDGEDETECTION_PROP"]/*' />
public enum D2D1_EDGEDETECTION_PROP : uint
{
    /// <include file='D2D1_EDGEDETECTION_PROP.xml' path='doc/member[@name="D2D1_EDGEDETECTION_PROP.D2D1_EDGEDETECTION_PROP_STRENGTH"]/*' />
    D2D1_EDGEDETECTION_PROP_STRENGTH = 0,

    /// <include file='D2D1_EDGEDETECTION_PROP.xml' path='doc/member[@name="D2D1_EDGEDETECTION_PROP.D2D1_EDGEDETECTION_PROP_BLUR_RADIUS"]/*' />
    D2D1_EDGEDETECTION_PROP_BLUR_RADIUS = 1,

    /// <include file='D2D1_EDGEDETECTION_PROP.xml' path='doc/member[@name="D2D1_EDGEDETECTION_PROP.D2D1_EDGEDETECTION_PROP_MODE"]/*' />
    D2D1_EDGEDETECTION_PROP_MODE = 2,

    /// <include file='D2D1_EDGEDETECTION_PROP.xml' path='doc/member[@name="D2D1_EDGEDETECTION_PROP.D2D1_EDGEDETECTION_PROP_OVERLAY_EDGES"]/*' />
    D2D1_EDGEDETECTION_PROP_OVERLAY_EDGES = 3,

    /// <include file='D2D1_EDGEDETECTION_PROP.xml' path='doc/member[@name="D2D1_EDGEDETECTION_PROP.D2D1_EDGEDETECTION_PROP_ALPHA_MODE"]/*' />
    D2D1_EDGEDETECTION_PROP_ALPHA_MODE = 4,

    /// <include file='D2D1_EDGEDETECTION_PROP.xml' path='doc/member[@name="D2D1_EDGEDETECTION_PROP.D2D1_EDGEDETECTION_PROP_FORCE_DWORD"]/*' />
    D2D1_EDGEDETECTION_PROP_FORCE_DWORD = 0xffffffff,
}
