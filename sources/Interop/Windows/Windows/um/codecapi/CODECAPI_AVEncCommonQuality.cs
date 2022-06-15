// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncCommonQuality.xml' path='doc/member[@name="CODECAPI_AVEncCommonQuality"]/*' />
[Guid("FCBF57A3-7EA5-4B0C-9644-69B40C39C391")]
public partial struct CODECAPI_AVEncCommonQuality : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncCommonQuality;
}
