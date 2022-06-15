// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncCommonPassStart.xml' path='doc/member[@name="CODECAPI_AVEncCommonPassStart"]/*' />
[Guid("6A67739F-4EB5-4385-9928-F276A939EF95")]
public partial struct CODECAPI_AVEncCommonPassStart : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncCommonPassStart;
}
