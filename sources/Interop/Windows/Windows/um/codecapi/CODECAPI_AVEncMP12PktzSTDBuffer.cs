// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMP12PktzSTDBuffer.xml' path='doc/member[@name="CODECAPI_AVEncMP12PktzSTDBuffer"]/*' />
[Guid("0B751BD0-819E-478C-9435-75208926B377")]
public partial struct CODECAPI_AVEncMP12PktzSTDBuffer : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMP12PktzSTDBuffer;
}
