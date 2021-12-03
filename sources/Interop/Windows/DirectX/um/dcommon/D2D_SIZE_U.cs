// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D_SIZE_U.xml' path='doc/member[@name="D2D_SIZE_U"]/*' />
public partial struct D2D_SIZE_U
{
    /// <include file='D2D_SIZE_U.xml' path='doc/member[@name="D2D_SIZE_U.width"]/*' />
    [NativeTypeName("UINT32")]
    public uint width;

    /// <include file='D2D_SIZE_U.xml' path='doc/member[@name="D2D_SIZE_U.height"]/*' />
    [NativeTypeName("UINT32")]
    public uint height;
}
