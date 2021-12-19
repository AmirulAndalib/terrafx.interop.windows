// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;

public static partial class E
{
    [NativeTypeName("#define E_SURFACE_CONTENTS_LOST 0x802b0020")]
    public const uint E_SURFACE_CONTENTS_LOST = 0x802b0020;
}
