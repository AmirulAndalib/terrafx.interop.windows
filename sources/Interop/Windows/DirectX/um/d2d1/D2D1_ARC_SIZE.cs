// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_ARC_SIZE.xml' path='doc/member[@name="D2D1_ARC_SIZE"]/*' />
public enum D2D1_ARC_SIZE
{
    /// <include file='D2D1_ARC_SIZE.xml' path='doc/member[@name="D2D1_ARC_SIZE.D2D1_ARC_SIZE_SMALL"]/*' />
    D2D1_ARC_SIZE_SMALL = 0,

    /// <include file='D2D1_ARC_SIZE.xml' path='doc/member[@name="D2D1_ARC_SIZE.D2D1_ARC_SIZE_LARGE"]/*' />
    D2D1_ARC_SIZE_LARGE = 1,

    /// <include file='D2D1_ARC_SIZE.xml' path='doc/member[@name="D2D1_ARC_SIZE.D2D1_ARC_SIZE_FORCE_DWORD"]/*' />
    D2D1_ARC_SIZE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
