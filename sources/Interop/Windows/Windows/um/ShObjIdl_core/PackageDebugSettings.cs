// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='PackageDebugSettings.xml' path='doc/member[@name="PackageDebugSettings"]/*' />
[Guid("B1AEC16F-2383-4852-B0E9-8F0B1DC66B4D")]
public unsafe partial struct PackageDebugSettings : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_PackageDebugSettings);
}
