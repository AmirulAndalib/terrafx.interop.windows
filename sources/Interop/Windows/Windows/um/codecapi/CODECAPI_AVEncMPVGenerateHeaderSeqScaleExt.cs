// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPVGenerateHeaderSeqScaleExt.xml' path='doc/member[@name="CODECAPI_AVEncMPVGenerateHeaderSeqScaleExt"]/*' />
[Guid("0722D62F-DD59-4A86-9CD5-644F8E2653D8")]
public partial struct CODECAPI_AVEncMPVGenerateHeaderSeqScaleExt : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMPVGenerateHeaderSeqScaleExt;
}
