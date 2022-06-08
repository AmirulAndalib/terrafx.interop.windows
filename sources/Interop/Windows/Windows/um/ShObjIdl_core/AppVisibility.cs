// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='AppVisibility.xml' path='doc/member[@name="AppVisibility"]/*' />
[Guid("7E5FE3D9-985F-4908-91F9-EE19F9FD1514")]
public partial struct AppVisibility : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_AppVisibility;
}
