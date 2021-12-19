// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class INET
{
    [NativeTypeName("#define INET_ADDRSTRLEN 22")]
    public const int INET_ADDRSTRLEN = 22;
}
