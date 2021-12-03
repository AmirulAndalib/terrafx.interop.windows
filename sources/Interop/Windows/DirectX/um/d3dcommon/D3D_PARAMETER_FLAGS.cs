// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS"]/*' />
[Flags]
public enum D3D_PARAMETER_FLAGS
{
    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_NONE"]/*' />
    D3D_PF_NONE = 0,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_IN"]/*' />
    D3D_PF_IN = 0x1,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_OUT"]/*' />
    D3D_PF_OUT = 0x2,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_FORCE_DWORD"]/*' />
    D3D_PF_FORCE_DWORD = 0x7fffffff,
}
