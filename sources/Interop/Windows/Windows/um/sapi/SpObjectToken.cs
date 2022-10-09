// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpObjectToken.xml' path='doc/member[@name="SpObjectToken"]/*' />
[Guid("EF411752-3736-4CB4-9C8C-8EF4CCB58EFE")]
public unsafe partial struct SpObjectToken : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_SpObjectToken));
}
