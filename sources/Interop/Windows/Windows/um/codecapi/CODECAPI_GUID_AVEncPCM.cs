// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncPCM.xml' path='doc/member[@name="CODECAPI_GUID_AVEncPCM"]/*' />
[Guid("844BE7F4-26CF-4779-B386-CC05D187990C")]
public partial struct CODECAPI_GUID_AVEncPCM : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_GUID_AVEncPCM;
}
