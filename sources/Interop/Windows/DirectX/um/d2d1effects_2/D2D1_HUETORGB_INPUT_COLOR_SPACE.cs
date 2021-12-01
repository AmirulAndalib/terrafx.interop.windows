// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_HUETORGB_INPUT_COLOR_SPACE.xml' path='doc/member[@name="D2D1_HUETORGB_INPUT_COLOR_SPACE"]/*' />
public enum D2D1_HUETORGB_INPUT_COLOR_SPACE : uint
{
    /// <include file='D2D1_HUETORGB_INPUT_COLOR_SPACE.xml' path='doc/member[@name="D2D1_HUETORGB_INPUT_COLOR_SPACE.D2D1_HUETORGB_INPUT_COLOR_SPACE_HUE_SATURATION_VALUE"]/*' />
    D2D1_HUETORGB_INPUT_COLOR_SPACE_HUE_SATURATION_VALUE = 0,

    /// <include file='D2D1_HUETORGB_INPUT_COLOR_SPACE.xml' path='doc/member[@name="D2D1_HUETORGB_INPUT_COLOR_SPACE.D2D1_HUETORGB_INPUT_COLOR_SPACE_HUE_SATURATION_LIGHTNESS"]/*' />
    D2D1_HUETORGB_INPUT_COLOR_SPACE_HUE_SATURATION_LIGHTNESS = 1,

    /// <include file='D2D1_HUETORGB_INPUT_COLOR_SPACE.xml' path='doc/member[@name="D2D1_HUETORGB_INPUT_COLOR_SPACE.D2D1_HUETORGB_INPUT_COLOR_SPACE_FORCE_DWORD"]/*' />
    D2D1_HUETORGB_INPUT_COLOR_SPACE_FORCE_DWORD = 0xffffffff,
}
