// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='V1SmartcardCredentialProvider.xml' path='doc/member[@name="V1SmartcardCredentialProvider"]/*' />
[Guid("8BF9A910-A8FF-457F-999F-A5CA10B4A885")]
public unsafe partial struct V1SmartcardCredentialProvider : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_V1SmartcardCredentialProvider);
}
