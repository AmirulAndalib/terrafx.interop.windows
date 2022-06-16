// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncDDDialogNormalization.xml' path='doc/member[@name="CODECAPI_AVEncDDDialogNormalization"]/*' />
[Guid("D7055ACF-F125-437D-A704-79C79F0404A8")]
public unsafe partial struct CODECAPI_AVEncDDDialogNormalization : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDDialogNormalization));
}
