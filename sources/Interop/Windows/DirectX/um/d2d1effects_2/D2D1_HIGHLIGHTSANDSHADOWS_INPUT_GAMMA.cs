// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA.xml' path='doc/member[@name="D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA"]/*' />
public enum D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA : uint
{
    /// <include file='D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA.xml' path='doc/member[@name="D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA.D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_LINEAR"]/*' />
    D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_LINEAR = 0,

    /// <include file='D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA.xml' path='doc/member[@name="D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA.D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_SRGB"]/*' />
    D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_SRGB = 1,

    /// <include file='D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA.xml' path='doc/member[@name="D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA.D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_FORCE_DWORD"]/*' />
    D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_FORCE_DWORD = 0xffffffff,
}
