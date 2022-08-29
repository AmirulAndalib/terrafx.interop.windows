// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.STATUS;

namespace TerraFX.Interop.Windows;

public static partial class EXCEPTION
{
    public const uint EXCEPTION_POSSIBLE_DEADLOCK = unchecked((uint)(STATUS_POSSIBLE_DEADLOCK));
}
