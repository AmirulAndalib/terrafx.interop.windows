// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoInputColorTransferMatrix.xml' path='doc/member[@name="CODECAPI_AVEncVideoInputColorTransferMatrix"]/*' />
[Guid("52ED68B9-72D5-4089-958D-F5405D55081C")]
public unsafe partial struct CODECAPI_AVEncVideoInputColorTransferMatrix : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoInputColorTransferMatrix));
}
