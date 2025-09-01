// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ShellImageDataFactory.xml' path='doc/member[@name="ShellImageDataFactory"]/*' />
[Guid("66E4E4FB-F385-4DD0-8D74-A2EFD1BC6178")]
public unsafe partial struct ShellImageDataFactory : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ShellImageDataFactory);
}
