// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIDSAM
{
    [NativeTypeName("#define DIDSAM_DEFAULT 0x00000000")]
    public const int DIDSAM_DEFAULT = 0x00000000;

    [NativeTypeName("#define DIDSAM_NOUSER 0x00000001")]
    public const int DIDSAM_NOUSER = 0x00000001;

    [NativeTypeName("#define DIDSAM_FORCESAVE 0x00000002")]
    public const int DIDSAM_FORCESAVE = 0x00000002;
}
