// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_SetHDCPManagerContext.xml' path='doc/member[@name="CODECAPI_SetHDCPManagerContext"]/*' />
[Guid("6D2D1FC8-3DC9-47EB-A1A2-471C80CD60D0")]
public partial struct CODECAPI_SetHDCPManagerContext : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_SetHDCPManagerContext;
}
