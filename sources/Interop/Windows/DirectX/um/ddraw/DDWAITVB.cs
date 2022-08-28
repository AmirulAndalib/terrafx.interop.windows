// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDWAITVB
{
    [NativeTypeName("#define DDWAITVB_BLOCKBEGIN 0x00000001l")]
    public const int DDWAITVB_BLOCKBEGIN = 0x00000001;

    [NativeTypeName("#define DDWAITVB_BLOCKBEGINEVENT 0x00000002l")]
    public const int DDWAITVB_BLOCKBEGINEVENT = 0x00000002;

    [NativeTypeName("#define DDWAITVB_BLOCKEND 0x00000004l")]
    public const int DDWAITVB_BLOCKEND = 0x00000004;
}
