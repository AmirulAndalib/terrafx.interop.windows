// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='MsftDiscMaster2.xml' path='doc/member[@name="MsftDiscMaster2"]/*' />
[Guid("2735412E-7F64-5B0F-8F00-5D77AFBE261E")]
public unsafe partial struct MsftDiscMaster2 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_MsftDiscMaster2));
}
