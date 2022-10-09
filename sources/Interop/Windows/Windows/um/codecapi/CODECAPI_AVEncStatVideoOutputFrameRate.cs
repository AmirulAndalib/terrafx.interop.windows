// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncStatVideoOutputFrameRate.xml' path='doc/member[@name="CODECAPI_AVEncStatVideoOutputFrameRate"]/*' />
[Guid("BE747849-9AB4-4A63-98FE-F143F04F8EE9")]
public unsafe partial struct CODECAPI_AVEncStatVideoOutputFrameRate : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncStatVideoOutputFrameRate));
}
