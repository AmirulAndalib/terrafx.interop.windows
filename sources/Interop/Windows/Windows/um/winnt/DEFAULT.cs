// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SECURITY_IMPERSONATION_LEVEL;

namespace TerraFX.Interop.Windows;

public static partial class DEFAULT
{
    [NativeTypeName("#define DEFAULT_IMPERSONATION_LEVEL SecurityImpersonation")]
    public const SECURITY_IMPERSONATION_LEVEL DEFAULT_IMPERSONATION_LEVEL = SecurityImpersonation;
}
