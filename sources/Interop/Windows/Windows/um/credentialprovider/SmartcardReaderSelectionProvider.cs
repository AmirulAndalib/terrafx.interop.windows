// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SmartcardReaderSelectionProvider.xml' path='doc/member[@name="SmartcardReaderSelectionProvider"]/*' />
[Guid("1B283861-754F-4022-AD47-A5EAAA618894")]
public unsafe partial struct SmartcardReaderSelectionProvider : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_SmartcardReaderSelectionProvider);
}
