// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ERROR
{
    [NativeTypeName("#define ERROR_SEVERITY_SUCCESS 0x00000000")]
    public const int ERROR_SEVERITY_SUCCESS = 0x00000000;

    [NativeTypeName("#define ERROR_SEVERITY_INFORMATIONAL 0x40000000")]
    public const int ERROR_SEVERITY_INFORMATIONAL = 0x40000000;

    [NativeTypeName("#define ERROR_SEVERITY_WARNING 0x80000000")]
    public const uint ERROR_SEVERITY_WARNING = 0x80000000;

    [NativeTypeName("#define ERROR_SEVERITY_ERROR 0xC0000000")]
    public const uint ERROR_SEVERITY_ERROR = 0xC0000000;
}
