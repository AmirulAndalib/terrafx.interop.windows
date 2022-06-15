// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPVGOPSizeMin.xml' path='doc/member[@name="CODECAPI_AVEncMPVGOPSizeMin"]/*' />
[Guid("7155CF20-D440-4852-AD0F-9C4ABFE37A6A")]
public partial struct CODECAPI_AVEncMPVGOPSizeMin : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMPVGOPSizeMin;
}
