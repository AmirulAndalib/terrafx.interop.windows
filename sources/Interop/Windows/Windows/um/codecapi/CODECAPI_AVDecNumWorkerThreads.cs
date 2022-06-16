// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecNumWorkerThreads.xml' path='doc/member[@name="CODECAPI_AVDecNumWorkerThreads"]/*' />
[Guid("9561C3E8-EA9E-4435-9B1E-A93E691894D8")]
public unsafe partial struct CODECAPI_AVDecNumWorkerThreads : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecNumWorkerThreads));
}
