// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoHeaderDropFrame.xml' path='doc/member[@name="CODECAPI_AVEncVideoHeaderDropFrame"]/*' />
[Guid("6ED9E124-7925-43FE-971B-E019F62222B4")]
public partial struct CODECAPI_AVEncVideoHeaderDropFrame : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoHeaderDropFrame;
}
