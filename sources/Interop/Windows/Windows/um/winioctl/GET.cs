// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GET
{
    [NativeTypeName("#define GET_VOLUME_BITMAP_FLAG_MASK_METADATA 0x00000001")]
    public const int GET_VOLUME_BITMAP_FLAG_MASK_METADATA = 0x00000001;
}
