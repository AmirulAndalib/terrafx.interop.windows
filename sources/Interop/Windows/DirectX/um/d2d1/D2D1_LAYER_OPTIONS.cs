// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_LAYER_OPTIONS.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS"]/*' />
[Flags]
public enum D2D1_LAYER_OPTIONS : uint
{
    /// <include file='D2D1_LAYER_OPTIONS.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS.D2D1_LAYER_OPTIONS_NONE"]/*' />
    D2D1_LAYER_OPTIONS_NONE = 0x00000000,

    /// <include file='D2D1_LAYER_OPTIONS.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS.D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE"]/*' />
    D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE = 0x00000001,

    /// <include file='D2D1_LAYER_OPTIONS.xml' path='doc/member[@name="D2D1_LAYER_OPTIONS.D2D1_LAYER_OPTIONS_FORCE_DWORD"]/*' />
    D2D1_LAYER_OPTIONS_FORCE_DWORD = 0xffffffff,
}
