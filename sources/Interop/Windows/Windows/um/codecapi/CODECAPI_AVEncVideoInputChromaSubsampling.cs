// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoInputChromaSubsampling.xml' path='doc/member[@name="CODECAPI_AVEncVideoInputChromaSubsampling"]/*' />
[Guid("A8E73A39-4435-4EC3-A6EA-98300F4B36F7")]
public partial struct CODECAPI_AVEncVideoInputChromaSubsampling : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoInputChromaSubsampling;
}
