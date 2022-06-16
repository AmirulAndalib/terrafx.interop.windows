// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMP12MuxSysVideoLock.xml' path='doc/member[@name="CODECAPI_AVEncMP12MuxSysVideoLock"]/*' />
[Guid("B8296408-2430-4D37-A2A1-95B3E435A91D")]
public unsafe partial struct CODECAPI_AVEncMP12MuxSysVideoLock : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMP12MuxSysVideoLock));
}
