// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoMaxCodedHeight.xml' path='doc/member[@name="CODECAPI_AVDecVideoMaxCodedHeight"]/*' />
[Guid("7262A16A-D2DC-4E75-9BA8-65C0C6D32B13")]
public unsafe partial struct CODECAPI_AVDecVideoMaxCodedHeight : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoMaxCodedHeight));
}
