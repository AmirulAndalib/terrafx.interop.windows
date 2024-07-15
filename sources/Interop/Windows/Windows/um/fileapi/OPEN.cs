// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class OPEN
{
    [NativeTypeName("#define OPEN_EXISTING 3")]
    public const int OPEN_EXISTING = 3;

    [NativeTypeName("#define OPEN_ALWAYS 4")]
    public const int OPEN_ALWAYS = 4;
}
