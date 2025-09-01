// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDDSurroundMode.xml' path='doc/member[@name="CODECAPI_AVDDSurroundMode"]/*' />
[Guid("99F2F386-98D1-4452-A163-ABC78A6EB770")]
public unsafe partial struct CODECAPI_AVDDSurroundMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVDDSurroundMode);
}
