// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='MSDiscRecorderObj.xml' path='doc/member[@name="MSDiscRecorderObj"]/*' />
[Guid("520CCA61-51A5-11D3-9144-00104BA11C5E")]
public partial struct MSDiscRecorderObj : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_MSDiscRecorderObj;
}
