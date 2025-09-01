// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVDecAudioInputHEAAC.xml' path='doc/member[@name="CODECAPI_GUID_AVDecAudioInputHEAAC"]/*' />
[Guid("16EFB4AA-330E-4F5C-98A8-CF6AC55CBE60")]
public unsafe partial struct CODECAPI_GUID_AVDecAudioInputHEAAC : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_GUID_AVDecAudioInputHEAAC);
}
