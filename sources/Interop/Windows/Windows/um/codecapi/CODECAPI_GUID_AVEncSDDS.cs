// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncSDDS.xml' path='doc/member[@name="CODECAPI_GUID_AVEncSDDS"]/*' />
[Guid("1DC1B82F-11C8-4C71-B7B6-EE3EB9BC2B94")]
public unsafe partial struct CODECAPI_GUID_AVEncSDDS : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncSDDS));
}
