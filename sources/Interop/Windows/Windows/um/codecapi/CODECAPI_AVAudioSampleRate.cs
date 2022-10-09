// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVAudioSampleRate.xml' path='doc/member[@name="CODECAPI_AVAudioSampleRate"]/*' />
[Guid("971D2723-1ACB-42E7-855C-520A4B70A5F2")]
public unsafe partial struct CODECAPI_AVAudioSampleRate : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVAudioSampleRate));
}
