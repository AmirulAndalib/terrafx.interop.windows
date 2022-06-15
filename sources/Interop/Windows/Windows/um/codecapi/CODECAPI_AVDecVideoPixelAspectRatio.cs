// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoPixelAspectRatio.xml' path='doc/member[@name="CODECAPI_AVDecVideoPixelAspectRatio"]/*' />
[Guid("B0CF8245-F32D-41DF-B02C-87BD304D12AB")]
public partial struct CODECAPI_AVDecVideoPixelAspectRatio : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecVideoPixelAspectRatio;
}
