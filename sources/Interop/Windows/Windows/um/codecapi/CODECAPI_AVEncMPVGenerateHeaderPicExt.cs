// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPVGenerateHeaderPicExt.xml' path='doc/member[@name="CODECAPI_AVEncMPVGenerateHeaderPicExt"]/*' />
[Guid("1B8464AB-944F-45F0-B74E-3A58DAD11F37")]
public unsafe partial struct CODECAPI_AVEncMPVGenerateHeaderPicExt : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPVGenerateHeaderPicExt));
}
