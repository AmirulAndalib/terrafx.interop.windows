// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='ShellBrowserWindow.xml' path='doc/member[@name="ShellBrowserWindow"]/*' />
[Guid("C08AFD90-F2A1-11D1-8455-00A0C91F3880")]
public unsafe partial struct ShellBrowserWindow : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_ShellBrowserWindow);
}
