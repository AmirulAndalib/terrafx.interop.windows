// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_PACKET_PROPERTY_COUNT 32")]
    public const int MAX_PACKET_PROPERTY_COUNT = 32;

    [NativeTypeName("#define MAX_PACKET_BUTTON_COUNT 32")]
    public const int MAX_PACKET_BUTTON_COUNT = 32;
}
