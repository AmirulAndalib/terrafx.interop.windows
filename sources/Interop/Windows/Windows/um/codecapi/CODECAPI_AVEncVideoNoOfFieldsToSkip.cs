// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoNoOfFieldsToSkip.xml' path='doc/member[@name="CODECAPI_AVEncVideoNoOfFieldsToSkip"]/*' />
[Guid("A97E1240-1427-4C16-A7F7-3DCFD8BA4CC5")]
public unsafe partial struct CODECAPI_AVEncVideoNoOfFieldsToSkip : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoNoOfFieldsToSkip));
}
