// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDEM
{
    [NativeTypeName("#define DDEM_MODEPASSED 0x00000001L")]
    public const int DDEM_MODEPASSED = 0x00000001;

    [NativeTypeName("#define DDEM_MODEFAILED 0x00000002L")]
    public const int DDEM_MODEFAILED = 0x00000002;
}
