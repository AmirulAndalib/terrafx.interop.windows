// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncDDCopyright.xml' path='doc/member[@name="CODECAPI_AVEncDDCopyright"]/*' />
[Guid("8694F076-CD75-481D-A5C6-A904DCC828F0")]
public unsafe partial struct CODECAPI_AVEncDDCopyright : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncDDCopyright);
}
