// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoForceSourceScanType.xml' path='doc/member[@name="CODECAPI_AVEncVideoForceSourceScanType"]/*' />
[Guid("1EF2065F-058A-4765-A4FC-8A864C103012")]
public partial struct CODECAPI_AVEncVideoForceSourceScanType : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoForceSourceScanType;
}
