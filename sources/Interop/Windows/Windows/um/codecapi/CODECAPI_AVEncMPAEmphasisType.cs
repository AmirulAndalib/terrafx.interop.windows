// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPAEmphasisType.xml' path='doc/member[@name="CODECAPI_AVEncMPAEmphasisType"]/*' />
[Guid("2D59FCDA-BF4E-4ED6-B5DF-5B03B36B0A1F")]
public unsafe partial struct CODECAPI_AVEncMPAEmphasisType : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPAEmphasisType));
}
