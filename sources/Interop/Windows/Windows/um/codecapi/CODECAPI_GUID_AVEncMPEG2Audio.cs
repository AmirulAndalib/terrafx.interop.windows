// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncMPEG2Audio.xml' path='doc/member[@name="CODECAPI_GUID_AVEncMPEG2Audio"]/*' />
[Guid("EE4CBB1F-9C3F-4770-92B5-FCB7C2A8D381")]
public unsafe partial struct CODECAPI_GUID_AVEncMPEG2Audio : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncMPEG2Audio));
}
