// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ENABLE
{
    [NativeTypeName("#define ENABLE_TLS_CLIENT_EARLY_START 0x00000001")]
    public const int ENABLE_TLS_CLIENT_EARLY_START = 0x00000001;
}
