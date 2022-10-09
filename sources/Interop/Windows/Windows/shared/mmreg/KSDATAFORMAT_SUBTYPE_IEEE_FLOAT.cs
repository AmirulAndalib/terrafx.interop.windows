// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='KSDATAFORMAT_SUBTYPE_IEEE_FLOAT.xml' path='doc/member[@name="KSDATAFORMAT_SUBTYPE_IEEE_FLOAT"]/*' />
[Guid("00000003-0000-0010-8000-00AA00389B71")]
public unsafe partial struct KSDATAFORMAT_SUBTYPE_IEEE_FLOAT : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_KSDATAFORMAT_SUBTYPE_IEEE_FLOAT));
}
