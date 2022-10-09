// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoAcceleration_VC1.xml' path='doc/member[@name="CODECAPI_AVDecVideoAcceleration_VC1"]/*' />
[Guid("F7DB8A30-4F48-4EE8-AE31-8B6EBE558AE2")]
public unsafe partial struct CODECAPI_AVDecVideoAcceleration_VC1 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoAcceleration_VC1));
}
