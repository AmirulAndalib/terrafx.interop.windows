// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoCTBSize.xml' path='doc/member[@name="CODECAPI_AVEncVideoCTBSize"]/*' />
[Guid("D47DB8B2-E73B-4CB9-8C3E-BD877D06D77B")]
public unsafe partial struct CODECAPI_AVEncVideoCTBSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoCTBSize));
}
