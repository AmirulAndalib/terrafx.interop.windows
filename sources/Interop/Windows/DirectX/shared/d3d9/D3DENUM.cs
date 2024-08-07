// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DENUM
{
    [NativeTypeName("#define D3DENUM_WHQL_LEVEL 0x00000002L")]
    public const int D3DENUM_WHQL_LEVEL = 0x00000002;

    [NativeTypeName("#define D3DENUM_NO_DRIVERVERSION 0x00000004L")]
    public const int D3DENUM_NO_DRIVERVERSION = 0x00000004;
}
