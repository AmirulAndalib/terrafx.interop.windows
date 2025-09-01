// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='FrameworkInputPane.xml' path='doc/member[@name="FrameworkInputPane"]/*' />
[Guid("D5120AA3-46BA-44C5-822D-CA8092C1FC72")]
public unsafe partial struct FrameworkInputPane : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_FrameworkInputPane);
}
