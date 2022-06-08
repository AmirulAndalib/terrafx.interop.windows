// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpMMAudioEnum.xml' path='doc/member[@name="SpMMAudioEnum"]/*' />
[Guid("AB1890A0-E91F-11D2-BB91-00C04F8EE6C0")]
public partial struct SpMMAudioEnum : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpMMAudioEnum;
}
