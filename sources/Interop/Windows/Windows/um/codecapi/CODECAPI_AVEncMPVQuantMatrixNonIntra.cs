// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPVQuantMatrixNonIntra.xml' path='doc/member[@name="CODECAPI_AVEncMPVQuantMatrixNonIntra"]/*' />
[Guid("87F441D8-0997-4BEB-A08E-8573D409CF75")]
public unsafe partial struct CODECAPI_AVEncMPVQuantMatrixNonIntra : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPVQuantMatrixNonIntra));
}
