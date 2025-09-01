// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncWMVProduceDummyFrames.xml' path='doc/member[@name="CODECAPI_AVEncWMVProduceDummyFrames"]/*' />
[Guid("D669D001-183C-42E3-A3CA-2F4586D2396C")]
public unsafe partial struct CODECAPI_AVEncWMVProduceDummyFrames : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncWMVProduceDummyFrames);
}
