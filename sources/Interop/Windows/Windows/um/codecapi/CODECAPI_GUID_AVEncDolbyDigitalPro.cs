// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncDolbyDigitalPro.xml' path='doc/member[@name="CODECAPI_GUID_AVEncDolbyDigitalPro"]/*' />
[Guid("F5BE76CC-0FF8-40EB-9CB1-BBA94004D44F")]
public unsafe partial struct CODECAPI_GUID_AVEncDolbyDigitalPro : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncDolbyDigitalPro));
}
