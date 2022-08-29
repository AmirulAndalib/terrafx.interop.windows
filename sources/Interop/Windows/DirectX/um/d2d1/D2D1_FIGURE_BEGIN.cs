// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_FIGURE_BEGIN.xml' path='doc/member[@name="D2D1_FIGURE_BEGIN"]/*' />
public enum D2D1_FIGURE_BEGIN : uint
{
    /// <include file='D2D1_FIGURE_BEGIN.xml' path='doc/member[@name="D2D1_FIGURE_BEGIN.D2D1_FIGURE_BEGIN_FILLED"]/*' />
    D2D1_FIGURE_BEGIN_FILLED = 0,

    /// <include file='D2D1_FIGURE_BEGIN.xml' path='doc/member[@name="D2D1_FIGURE_BEGIN.D2D1_FIGURE_BEGIN_HOLLOW"]/*' />
    D2D1_FIGURE_BEGIN_HOLLOW = 1,

    /// <include file='D2D1_FIGURE_BEGIN.xml' path='doc/member[@name="D2D1_FIGURE_BEGIN.D2D1_FIGURE_BEGIN_FORCE_DWORD"]/*' />
    D2D1_FIGURE_BEGIN_FORCE_DWORD = 0xffffffff,
}
