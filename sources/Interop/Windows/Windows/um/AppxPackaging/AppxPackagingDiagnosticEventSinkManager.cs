// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='AppxPackagingDiagnosticEventSinkManager.xml' path='doc/member[@name="AppxPackagingDiagnosticEventSinkManager"]/*' />
[Guid("50CA0A46-1588-4161-8ED2-EF9E469CED5D")]
public unsafe partial struct AppxPackagingDiagnosticEventSinkManager : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_AppxPackagingDiagnosticEventSinkManager));
}
