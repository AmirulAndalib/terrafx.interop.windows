// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncH264CABACEnable.xml' path='doc/member[@name="CODECAPI_AVEncH264CABACEnable"]/*' />
[Guid("EE6CAD62-D305-4248-A50E-E1B255F7CAF8")]
public unsafe partial struct CODECAPI_AVEncH264CABACEnable : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncH264CABACEnable);
}
