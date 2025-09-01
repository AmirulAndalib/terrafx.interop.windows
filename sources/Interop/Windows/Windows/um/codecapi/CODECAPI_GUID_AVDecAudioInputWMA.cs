// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVDecAudioInputWMA.xml' path='doc/member[@name="CODECAPI_GUID_AVDecAudioInputWMA"]/*' />
[Guid("C95E8DCF-4058-4204-8C42-CB24D91E4B9B")]
public unsafe partial struct CODECAPI_GUID_AVDecAudioInputWMA : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_GUID_AVDecAudioInputWMA);
}
