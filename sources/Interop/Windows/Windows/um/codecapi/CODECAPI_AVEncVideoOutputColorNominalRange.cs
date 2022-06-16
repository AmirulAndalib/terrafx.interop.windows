// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoOutputColorNominalRange.xml' path='doc/member[@name="CODECAPI_AVEncVideoOutputColorNominalRange"]/*' />
[Guid("972835ED-87B5-4E95-9500-C73958566E54")]
public unsafe partial struct CODECAPI_AVEncVideoOutputColorNominalRange : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoOutputColorNominalRange));
}
