// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='TrayBandSiteService.xml' path='doc/member[@name="TrayBandSiteService"]/*' />
[Guid("F60AD0A0-E5E1-45CB-B51A-E15B9F8B2934")]
public unsafe partial struct TrayBandSiteService : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_TrayBandSiteService);
}
