// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncStatWMVCBMax.xml' path='doc/member[@name="CODECAPI_AVEncStatWMVCBMax"]/*' />
[Guid("E976BEF8-00FE-44B4-B625-8F238BC03499")]
public partial struct CODECAPI_AVEncStatWMVCBMax : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncStatWMVCBMax;
}
