// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inputpanelconfiguration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='InputPanelConfiguration.xml' path='doc/member[@name="InputPanelConfiguration"]/*' />
[Guid("2853ADD3-F096-4C63-A78F-7FA3EA837FB7")]
public unsafe partial struct InputPanelConfiguration : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_InputPanelConfiguration));
}
