// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class WC
{
    [NativeTypeName("#define WC_DIALOG (MAKEINTATOM(0x8002))")]
    public static char* WC_DIALOG => ((char*)((nuint)((ushort)(0x8002))));
}
