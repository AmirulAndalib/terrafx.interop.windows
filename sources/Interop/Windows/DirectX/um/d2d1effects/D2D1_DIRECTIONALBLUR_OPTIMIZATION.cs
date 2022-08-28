// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_DIRECTIONALBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_DIRECTIONALBLUR_OPTIMIZATION"]/*' />
public enum D2D1_DIRECTIONALBLUR_OPTIMIZATION : uint
{
    /// <include file='D2D1_DIRECTIONALBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_DIRECTIONALBLUR_OPTIMIZATION.D2D1_DIRECTIONALBLUR_OPTIMIZATION_SPEED"]/*' />
    D2D1_DIRECTIONALBLUR_OPTIMIZATION_SPEED = 0,

    /// <include file='D2D1_DIRECTIONALBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_DIRECTIONALBLUR_OPTIMIZATION.D2D1_DIRECTIONALBLUR_OPTIMIZATION_BALANCED"]/*' />
    D2D1_DIRECTIONALBLUR_OPTIMIZATION_BALANCED = 1,

    /// <include file='D2D1_DIRECTIONALBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_DIRECTIONALBLUR_OPTIMIZATION.D2D1_DIRECTIONALBLUR_OPTIMIZATION_QUALITY"]/*' />
    D2D1_DIRECTIONALBLUR_OPTIMIZATION_QUALITY = 2,

    /// <include file='D2D1_DIRECTIONALBLUR_OPTIMIZATION.xml' path='doc/member[@name="D2D1_DIRECTIONALBLUR_OPTIMIZATION.D2D1_DIRECTIONALBLUR_OPTIMIZATION_FORCE_DWORD"]/*' />
    D2D1_DIRECTIONALBLUR_OPTIMIZATION_FORCE_DWORD = 0xffffffff,
}
