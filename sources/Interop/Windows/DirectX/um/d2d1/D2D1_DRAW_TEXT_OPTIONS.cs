// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_DRAW_TEXT_OPTIONS.xml' path='doc/member[@name="D2D1_DRAW_TEXT_OPTIONS"]/*' />
[Flags]
public enum D2D1_DRAW_TEXT_OPTIONS : uint
{
    /// <include file='D2D1_DRAW_TEXT_OPTIONS.xml' path='doc/member[@name="D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NO_SNAP"]/*' />
    D2D1_DRAW_TEXT_OPTIONS_NO_SNAP = 0x00000001,

    /// <include file='D2D1_DRAW_TEXT_OPTIONS.xml' path='doc/member[@name="D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_CLIP"]/*' />
    D2D1_DRAW_TEXT_OPTIONS_CLIP = 0x00000002,

    /// <include file='D2D1_DRAW_TEXT_OPTIONS.xml' path='doc/member[@name="D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT"]/*' />
    D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT = 0x00000004,

    /// <include file='D2D1_DRAW_TEXT_OPTIONS.xml' path='doc/member[@name="D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING"]/*' />
    D2D1_DRAW_TEXT_OPTIONS_DISABLE_COLOR_BITMAP_SNAPPING = 0x00000008,

    /// <include file='D2D1_DRAW_TEXT_OPTIONS.xml' path='doc/member[@name="D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE"]/*' />
    D2D1_DRAW_TEXT_OPTIONS_NONE = 0x00000000,

    /// <include file='D2D1_DRAW_TEXT_OPTIONS.xml' path='doc/member[@name="D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_FORCE_DWORD"]/*' />
    D2D1_DRAW_TEXT_OPTIONS_FORCE_DWORD = 0xffffffff,
}
