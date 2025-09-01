// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecDDDynamicRangeScaleHigh.xml' path='doc/member[@name="CODECAPI_AVDecDDDynamicRangeScaleHigh"]/*' />
[Guid("50196C21-1F33-4AF5-B296-11426D6C8789")]
public unsafe partial struct CODECAPI_AVDecDDDynamicRangeScaleHigh : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVDecDDDynamicRangeScaleHigh);
}
