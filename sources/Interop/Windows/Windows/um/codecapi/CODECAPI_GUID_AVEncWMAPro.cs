// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncWMAPro.xml' path='doc/member[@name="CODECAPI_GUID_AVEncWMAPro"]/*' />
[Guid("1955F90C-33F7-4A68-AB81-53F5657125C4")]
public partial struct CODECAPI_GUID_AVEncWMAPro : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_GUID_AVEncWMAPro;
}
