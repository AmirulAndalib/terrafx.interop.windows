// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_MORPHOLOGY_MODE.xml' path='doc/member[@name="D2D1_MORPHOLOGY_MODE"]/*' />
public enum D2D1_MORPHOLOGY_MODE : uint
{
    /// <include file='D2D1_MORPHOLOGY_MODE.xml' path='doc/member[@name="D2D1_MORPHOLOGY_MODE.D2D1_MORPHOLOGY_MODE_ERODE"]/*' />
    D2D1_MORPHOLOGY_MODE_ERODE = 0,

    /// <include file='D2D1_MORPHOLOGY_MODE.xml' path='doc/member[@name="D2D1_MORPHOLOGY_MODE.D2D1_MORPHOLOGY_MODE_DILATE"]/*' />
    D2D1_MORPHOLOGY_MODE_DILATE = 1,

    /// <include file='D2D1_MORPHOLOGY_MODE.xml' path='doc/member[@name="D2D1_MORPHOLOGY_MODE.D2D1_MORPHOLOGY_MODE_FORCE_DWORD"]/*' />
    D2D1_MORPHOLOGY_MODE_FORCE_DWORD = 0xffffffff,
}
