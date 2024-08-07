// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_DEVICE_IDENTIFIER_STRING 512")]
    public const int MAX_DEVICE_IDENTIFIER_STRING = 512;
}
