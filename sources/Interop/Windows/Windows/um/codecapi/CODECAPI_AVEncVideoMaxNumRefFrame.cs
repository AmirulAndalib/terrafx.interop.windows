// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoMaxNumRefFrame.xml' path='doc/member[@name="CODECAPI_AVEncVideoMaxNumRefFrame"]/*' />
[Guid("964829ED-94F9-43B4-B74D-EF40944B69A0")]
public unsafe partial struct CODECAPI_AVEncVideoMaxNumRefFrame : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoMaxNumRefFrame));
}
